#pragma checksum "/Users/redone/git/DevCodeCamp/Week_10/Projects/live-tunes/src/LiveTunes.MVC/Views/MusicPreference/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ae07356ded130a51feeddfe5ec9a5ba9ef9551b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MusicPreference_Index), @"mvc.1.0.view", @"/Views/MusicPreference/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MusicPreference/Index.cshtml", typeof(AspNetCore.Views_MusicPreference_Index))]
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
#line 1 "/Users/redone/git/DevCodeCamp/Week_10/Projects/live-tunes/src/LiveTunes.MVC/Views/_ViewImports.cshtml"
using LiveTunes.MVC;

#line default
#line hidden
#line 2 "/Users/redone/git/DevCodeCamp/Week_10/Projects/live-tunes/src/LiveTunes.MVC/Views/_ViewImports.cshtml"
using LiveTunes.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ae07356ded130a51feeddfe5ec9a5ba9ef9551b", @"/Views/MusicPreference/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e75b8771a7fe2bd07c253cf3e55456eba79fbb6", @"/Views/_ViewImports.cshtml")]
    public class Views_MusicPreference_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Newtonsoft.Json.Linq.JToken>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/redone/git/DevCodeCamp/Week_10/Projects/live-tunes/src/LiveTunes.MVC/Views/MusicPreference/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(73, 94, true);
            WriteLiteral("\n<h1>Index</h1>\n\n<h4>MusicPreference</h4>\n<hr />\n<div class=\"row\">\n    <div class=\"col-md-4\">\n");
            EndContext();
#line 12 "/Users/redone/git/DevCodeCamp/Week_10/Projects/live-tunes/src/LiveTunes.MVC/Views/MusicPreference/Index.cshtml"
         for (int i = 0; i < Model.Count(); i++) {

#line default
#line hidden
            BeginContext(218, 17, true);
            WriteLiteral("            <div>");
            EndContext();
            BeginContext(236, 21, false);
#line 13 "/Users/redone/git/DevCodeCamp/Week_10/Projects/live-tunes/src/LiveTunes.MVC/Views/MusicPreference/Index.cshtml"
            Write(Model[i]["trackName"]);

#line default
#line hidden
            EndContext();
            BeginContext(257, 8, true);
            WriteLiteral(";</div>\n");
            EndContext();
#line 14 "/Users/redone/git/DevCodeCamp/Week_10/Projects/live-tunes/src/LiveTunes.MVC/Views/MusicPreference/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(275, 1579, true);
            WriteLiteral(@"        <!---
    <form asp-action=""Index"">
        <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
        <div class=""form-group"">
            <label asp-for=""UserId"" class=""control-label""></label>
            <input asp-for=""UserId"" class=""form-control"" />
            <span asp-validation-for=""UserId"" class=""text-danger""></span>
        </div>
        <div class=""form-group"">
            <label asp-for=""MusicPreferenceId"" class=""control-label""></label>
            <input asp-for=""MusicPreferenceId"" class=""form-control"" />
            <span asp-validation-for=""MusicPreferenceId"" class=""text-danger""></span>
        </div>
        <div class=""form-group"">
            <label asp-for=""ArtistName"" class=""control-label""></label>
            <input asp-for=""ArtistName"" class=""form-control"" />
            <span asp-validation-for=""ArtistName"" class=""text-danger""></span>
        </div>
        <div class=""form-group"">
            <label asp-for=""SongName"" class=""control-label""></label>
           ");
            WriteLiteral(@" <input asp-for=""SongName"" class=""form-control"" />
            <span asp-validation-for=""SongName"" class=""text-danger""></span>
        </div>
        <div class=""form-group"">
            <label asp-for=""Genre"" class=""control-label""></label>
            <input asp-for=""Genre"" class=""form-control"" />
            <span asp-validation-for=""Genre"" class=""text-danger""></span>
        </div>
        <div class=""form-group"">
            <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
        </div>
    </form>-->
    </div>
</div>

<div>
    ");
            EndContext();
            BeginContext(1854, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae07356ded130a51feeddfe5ec9a5ba9ef9551b6502", async() => {
                BeginContext(1876, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1892, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1919, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 55 "/Users/redone/git/DevCodeCamp/Week_10/Projects/live-tunes/src/LiveTunes.MVC/Views/MusicPreference/Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Newtonsoft.Json.Linq.JToken> Html { get; private set; }
    }
}
#pragma warning restore 1591