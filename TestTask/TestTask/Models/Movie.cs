using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название фильма")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Дата выпуска")]
        public DateTime DateOfIssue { get; set; }
        [Display(Name = "Режиссер")]
        public string ProducerName { get; set; }
        public string Poster { get; set; }
        [Required]
        [Display(Name = "Постер")]
        public IFormFile formFile { get; set; }
        public IdentityUser Author { get; set; }
    }
}
