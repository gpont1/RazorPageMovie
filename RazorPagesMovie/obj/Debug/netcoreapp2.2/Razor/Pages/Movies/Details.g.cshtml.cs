#pragma checksum "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d917ef206d619fe33aaa2b02917ad92d85c6ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMovie.Pages.Movies.Pages_Movies_Details), @"mvc.1.0.razor-page", @"/Pages/Movies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Movies/Details.cshtml", typeof(RazorPagesMovie.Pages.Movies.Pages_Movies_Details), null)]
namespace RazorPagesMovie.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\_ViewImports.cshtml"
using RazorPagesMovie;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d917ef206d619fe33aaa2b02917ad92d85c6ce", @"/Pages/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bffd98f02597e6a09295a2131188dc64093be78", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Movies_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\Movies\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 126, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Movie</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(276, 47, false);
#line 16 "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Title));

#line default
#line hidden
            EndContext();
            BeginContext(323, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(385, 43, false);
#line 19 "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Title));

#line default
#line hidden
            EndContext();
            BeginContext(428, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(489, 53, false);
#line 22 "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(542, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(604, 49, false);
#line 25 "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Movie.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(653, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(714, 47, false);
#line 28 "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(761, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(823, 43, false);
#line 31 "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(866, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(927, 47, false);
#line 34 "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Price));

#line default
#line hidden
            EndContext();
            BeginContext(974, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1036, 43, false);
#line 37 "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 61, true);
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1141, 44, false);
#line 40 "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1232, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61d917ef206d619fe33aaa2b02917ad92d85c6ce8081", async() => {
                BeginContext(1284, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\humbl\source\repos\RazorPagesMovie\RazorPagesMovie\Pages\Movies\Details.cshtml"
                           WriteLiteral(Model.Movie.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1292, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1300, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61d917ef206d619fe33aaa2b02917ad92d85c6ce10414", async() => {
                BeginContext(1322, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1338, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Pages.Movies.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.Movies.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.Movies.DetailsModel>)PageContext?.ViewData;
        public RazorPagesMovie.Pages.Movies.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
