#pragma checksum "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "411ab2445df670e06972554db26598b0947dcc03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\_ViewImports.cshtml"
using BeltReview;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\_ViewImports.cshtml"
using BeltReview.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"411ab2445df670e06972554db26598b0947dcc03", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0e672077ba5cc5e69ddcdc4bb14a3b2ce72e27f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "411ab2445df670e06972554db26598b0947dcc033384", async() => {
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
            WriteLiteral("\r\n<h1>Welcome, ");
#nullable restore
#line 2 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
        Write(ViewBag.loggedInUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"d-flex \">\r\n");
#nullable restore
#line 5 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
      
        foreach(Post p in ViewBag.AllPost)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card m-2\" style=\"width: 18rem;\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 250, "\"", 272, 2);
            WriteAttributeValue("", 257, "/post/", 257, 6, true);
#nullable restore
#line 9 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 263, p.PostId, 263, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 278, "\"", 290, 1);
#nullable restore
#line 9 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 284, p.URL, 284, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"Pet\"></a>\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">Posted by: ");
#nullable restore
#line 11 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
                                                 Write(p.Poster.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
                                                                     Write(p.Poster.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h6>");
#nullable restore
#line 12 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
                   Write(p.LikedBy.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Like(s)</h6>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 13 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
                                    Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
                      
                        if(p.UserId == ViewBag.LoggedInUser.UserId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 735, "\"", 759, 2);
            WriteAttributeValue("", 742, "/delete/", 742, 8, true);
#nullable restore
#line 17 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 750, p.PostId, 750, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 826, "\"", 848, 2);
            WriteAttributeValue("", 833, "/edit/", 833, 6, true);
#nullable restore
#line 18 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 839, p.PostId, 839, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Edit</a>\r\n");
#nullable restore
#line 19 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
                            if(p.LikedBy.Any(f=>f.UserId == ViewBag.LoggedInUser.UserId))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1033, "\"", 1086, 4);
            WriteAttributeValue("", 1040, "/unlike/", 1040, 8, true);
#nullable restore
#line 21 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1048, p.PostId, 1048, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1057, "/", 1057, 1, true);
#nullable restore
#line 21 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1058, ViewBag.loggedInUser.UserId, 1058, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">UnLike</a>\r\n");
#nullable restore
#line 22 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
                            } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1196, "\"", 1247, 4);
            WriteAttributeValue("", 1203, "/like/", 1203, 6, true);
#nullable restore
#line 23 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1209, p.PostId, 1209, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1218, "/", 1218, 1, true);
#nullable restore
#line 23 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1219, ViewBag.loggedInUser.UserId, 1219, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Like</a>\r\n");
#nullable restore
#line 24 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
                            }
                        } else {
                            if(p.LikedBy.Any(f=>f.UserId == ViewBag.LoggedInUser.UserId))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1500, "\"", 1553, 4);
            WriteAttributeValue("", 1507, "/unlike/", 1507, 8, true);
#nullable restore
#line 28 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1515, p.PostId, 1515, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1524, "/", 1524, 1, true);
#nullable restore
#line 28 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1525, ViewBag.loggedInUser.UserId, 1525, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">UnLike</a>\r\n");
#nullable restore
#line 29 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
                            } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1663, "\"", 1714, 4);
            WriteAttributeValue("", 1670, "/like/", 1670, 6, true);
#nullable restore
#line 30 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1676, p.PostId, 1676, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1685, "/", 1685, 1, true);
#nullable restore
#line 30 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1686, ViewBag.loggedInUser.UserId, 1686, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Like</a>\r\n");
#nullable restore
#line 31 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Lectures\BeltReview\Views\Home\Dashboard.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
