#pragma checksum "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e71d8884f51978ba75cffd052ff1ee15435b7c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
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
#line 1 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\_ViewImports.cshtml"
using Artistry;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\_ViewImports.cshtml"
using Artistry.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e71d8884f51978ba75cffd052ff1ee15435b7c24", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b48510b72b5666ffed52ec40c56d720b535d6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Artist>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Navbar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e71d8884f51978ba75cffd052ff1ee15435b7c243321", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h1>Artwork</h1>\r\n");
            WriteLiteral("\r\n<img");
            BeginWriteAttribute("src", " src=\"", 74, "\"", 96, 1);
#nullable restore
#line 5 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
WriteAttributeValue("", 80, Model.Technique, 80, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"post\" style=\"width: 22rem;\">\r\n<h3>");
#nullable restore
#line 6 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n<h4>");
#nullable restore
#line 7 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h6>");
#nullable restore
#line 8 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
Write(Model.difSkill.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" like(s)</h6>\r\n");
#nullable restore
#line 9 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
  
    if(Model.UserId == ViewBag.LoggedInUser.UserId)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 300, "\"", 330, 2);
            WriteAttributeValue("", 307, "/delete/", 307, 8, true);
#nullable restore
#line 12 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
WriteAttributeValue("", 315, Model.ArtistId, 315, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 377, "\"", 405, 2);
            WriteAttributeValue("", 384, "/edit/", 384, 6, true);
#nullable restore
#line 13 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
WriteAttributeValue("", 390, Model.ArtistId, 390, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Edit</a>\r\n");
#nullable restore
#line 14 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
        if(Model.difSkill.Any(f=>f.UserId == ViewBag.LoggedInUser.UserId))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 535, "\"", 594, 4);
            WriteAttributeValue("", 542, "/unlike/", 542, 8, true);
#nullable restore
#line 16 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
WriteAttributeValue("", 550, Model.ArtistId, 550, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 565, "/", 565, 1, true);
#nullable restore
#line 16 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
WriteAttributeValue("", 566, ViewBag.loggedInUser.UserId, 566, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">UnLike</a>\r\n");
#nullable restore
#line 17 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 664, "\"", 721, 4);
            WriteAttributeValue("", 671, "/like/", 671, 6, true);
#nullable restore
#line 18 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
WriteAttributeValue("", 677, Model.ArtistId, 677, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 692, "/", 692, 1, true);
#nullable restore
#line 18 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
WriteAttributeValue("", 693, ViewBag.loggedInUser.UserId, 693, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Like</a>\r\n");
#nullable restore
#line 19 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
        }
    } else {
        if(Model.difSkill.Any(f=>f.UserId == ViewBag.LoggedInUser.UserId))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 879, "\"", 938, 4);
            WriteAttributeValue("", 886, "/unlike/", 886, 8, true);
#nullable restore
#line 23 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
WriteAttributeValue("", 894, Model.ArtistId, 894, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 909, "/", 909, 1, true);
#nullable restore
#line 23 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
WriteAttributeValue("", 910, ViewBag.loggedInUser.UserId, 910, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">UnLike</a>\r\n");
#nullable restore
#line 24 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 1008, "\"", 1065, 4);
            WriteAttributeValue("", 1015, "/like/", 1015, 6, true);
#nullable restore
#line 25 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
WriteAttributeValue("", 1021, Model.ArtistId, 1021, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1036, "/", 1036, 1, true);
#nullable restore
#line 25 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
WriteAttributeValue("", 1037, ViewBag.loggedInUser.UserId, 1037, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Like</a>\r\n");
#nullable restore
#line 26 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Artistry\Views\Home\Show.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Artist> Html { get; private set; }
    }
}
#pragma warning restore 1591
