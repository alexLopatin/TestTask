#pragma checksum "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f4f48b498d99471f9bdcfda76e6cc0760798e19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MovieList), @"mvc.1.0.view", @"/Views/Movie/MovieList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\_ViewImports.cshtml"
using TestTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\_ViewImports.cshtml"
using TestTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f4f48b498d99471f9bdcfda76e6cc0760798e19", @"/Views/Movie/MovieList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05cf8f63ba1d33f6434e3ef320625887168eb93", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_MovieList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageList<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
  
    var user = await userManager.GetUserAsync(User);
    var userId = user?.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Список фильмов</h2>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-primary\" href=\"/Movie/Create\" style=\"margin:10px;\">\r\n    Добавить описание\r\n</a>\r\n");
#nullable restore
#line 17 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Название</th>
            <th scope=""col"">Режиссер</th>
            <th scope=""col"">Год выпуска</th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
         foreach (var movie in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f4f48b498d99471f9bdcfda76e6cc0760798e196324", async() => {
#nullable restore
#line 33 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                                                                                                 Write(movie.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                                                                               WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n                <th scope=\"row\">");
#nullable restore
#line 34 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                           Write(movie.ProducerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"row\">");
#nullable restore
#line 35 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                           Write(movie.DateOfIssue.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 36 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                 if (userId == movie.Author.Id)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th scope=\"row\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f4f48b498d99471f9bdcfda76e6cc0760798e199899", async() => {
                WriteLiteral("Изменить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                                                                                  WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n");
#nullable restore
#line 39 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"page-links\">\r\n    <div style=\"margin:50px; font-size: 18px;\">\r\n");
#nullable restore
#line 47 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
         if (Model.CountOfPages <= 10)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a style=\"margin:10px;\">Страницы:</a>\r\n");
#nullable restore
#line 50 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
             for (int i = 1; i <= Model.CountOfPages; i++)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                 if (i != Model.PageIndex)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f4f48b498d99471f9bdcfda76e6cc0760798e1913732", async() => {
#nullable restore
#line 55 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                                                                                           WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a style=\"margin:10px;\">");
#nullable restore
#line 59 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 60 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a style=\"margin:10px;\">Страницы:</a>\r\n");
#nullable restore
#line 66 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
             if (Model.PageIndex > 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a style=\"margin:10px;\">...</a>\r\n");
#nullable restore
#line 69 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
             for (int i = (Model.PageIndex > 1 ? Model.PageIndex - 1 : Model.PageIndex); i <= Math.Min(Model.PageIndex + 5, Model.CountOfPages); i++)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                 if (i != Model.PageIndex)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f4f48b498d99471f9bdcfda76e6cc0760798e1918864", async() => {
#nullable restore
#line 75 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                                                                                           WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a style=\"margin:10px;\">");
#nullable restore
#line 79 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 80 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
             if (Model.PageIndex + 5 < Model.CountOfPages - 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a style=\"margin:10px;\">...</a>\r\n");
#nullable restore
#line 85 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
             if (Model.PageIndex + 5 < Model.CountOfPages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f4f48b498d99471f9bdcfda76e6cc0760798e1923368", async() => {
#nullable restore
#line 88 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                                                                                                                   Write(Model.CountOfPages);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
                                                                                       WriteLiteral(Model.CountOfPages);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 89 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\Admin\Documents\GitHub\TestTask\TestTask\TestTask\Views\Movie\MovieList.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageList<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
