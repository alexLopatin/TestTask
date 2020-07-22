using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestTask.Domain;
using TestTask.Models;

namespace TestTask.Controllers
{
    public class MovieController : Controller
    {
        public const int CountOnPage = 10;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _appEnvironment;
        public MovieController(UserManager<IdentityUser> userManager,
            AppDbContext context,
            IWebHostEnvironment appEnvironment)
        {
            _userManager = userManager;
            _context = context;
            _appEnvironment = appEnvironment;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            var movie = _context.Movies.Include(m=>m.Author).FirstOrDefault(m=>m.Id == id);
            return View(movie);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var movie = _context.Movies
                .Include(m => m.Author)
                .FirstOrDefault(m=>m.Id == id);
            var user = await _userManager.GetUserAsync(User);
            if (user.Id == movie.Author.Id)
                return View(movie);
            else
                return View();
        }
        [NonAction]
        private async void LoadFile(IFormFile formFile)
        {
            string path = _appEnvironment.WebRootPath + "/Files/" + formFile.FileName;
            //больше 5 мбайт
            if(formFile.Length > 1024 * 1024 * 5)
            {
                ModelState.AddModelError("", "Файл слишком большой");
                return;
            }
            if (!Directory.Exists(_appEnvironment.WebRootPath + "/Files/"))
                Directory.CreateDirectory(_appEnvironment.WebRootPath + "/Files/");
            if (System.IO.File.Exists(path))
            {
                ModelState.AddModelError("", "Файл с подобным именем уже существует");
                return;
            }
            using (var fs = new FileStream(path, FileMode.Create))
                await formFile.CopyToAsync(fs);
        }

        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(Movie model)
        {
            if(ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                model.Author = user;
                LoadFile(model.formFile);
                if(!ModelState.IsValid)
                    return View(model);
                model.Poster = "/Files/" + model.formFile.FileName;
                _context.Movies.Add(model);
                _context.SaveChanges();
                ViewBag.message = $"Описание фильма '{model.Name}' успешно создано.";
                return View();
            }
            return View(model);
        }

        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Edit(Movie model)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new Exception();
                var user = await _userManager.GetUserAsync(User);
                model.Author = user;
                var modelInTable = _context.Movies.Find(model.Id);
                LoadFile(model.formFile);
                if (!ModelState.IsValid)
                    return View(model);
                _context.Entry(modelInTable).CurrentValues.SetValues(model);
                _context.SaveChanges();
                ViewBag.message = $"Описание фильма '{model.Name}' успешно изменено.";
                return View();
            }
            catch (Exception ex) 
            {
                ModelState.AddModelError("", ex.ToString());
            }
            return View(model);
        }
        [Route("")]
        [Route("movies")]
        public async Task<IActionResult> GetMovieList(int page = 1)
        {
            if(_context.Movies.Count() == 0)
                return View("MovieList", new PageList<Movie>(new List<Movie>(), 1,1,CountOnPage));
            page = Math.Clamp(page, 1, (int)Math.Ceiling(_context.Movies.Count() / (double)CountOnPage));
            var pageList = await PageList<Movie>.CreateAsync(_context.Movies.Include(m=>m.Author), page, CountOnPage);
            return View("MovieList", pageList);
        }
        [Authorize]
        public async Task<IActionResult> Generate()
        {
            var user = await _userManager.GetUserAsync(User);
            List<Movie> movies = new List<Movie>();
            for (int i = 0; i < 100000; i++)
            {
                Movie m = new Movie();
                m.Author = user;
                m.DateOfIssue = DateTime.Now;
                m.Name = DateTime.Now.ToString();
                m.ProducerName = user.UserName;
                movies.Add(m);
            }
            await _context.Movies.AddRangeAsync(movies);
            await _context.SaveChangesAsync(false);
            return Redirect("/movies");
        }

        [Route("/Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
