#pragma checksum "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Assignments\ProductsAndCategories\Views\Home\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "603f0660c7350804d723a62f9984e5364b0f24b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Category), @"mvc.1.0.view", @"/Views/Home/Category.cshtml")]
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
#line 1 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Assignments\ProductsAndCategories\Views\_ViewImports.cshtml"
using ProductsAndCategories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Assignments\ProductsAndCategories\Views\_ViewImports.cshtml"
using ProductsAndCategories.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"603f0660c7350804d723a62f9984e5364b0f24b8", @"/Views/Home/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3772dd1aab0a113eef9daa4fd8f7fdb8a407ef7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/addProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"display-4 text-center\">");
#nullable restore
#line 3 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Assignments\ProductsAndCategories\Views\Home\Category.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br>\r\n<a href=\"/categories\">Categories</a>\r\n<br>\r\n<div class=\"d-flex justify-content-between\">\r\n    <div class=\"col-6 me-auto p-2 bd-highlight\">\r\n        <h2 class=\"px-5 text-warning\">Products:</h2>\r\n        <br>\r\n");
#nullable restore
#line 11 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Assignments\ProductsAndCategories\Views\Home\Category.cshtml"
          
            foreach(Association a in Model.AssociatedAt)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3>");
#nullable restore
#line 14 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Assignments\ProductsAndCategories\Views\Home\Category.cshtml"
               Write(a.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 15 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Assignments\ProductsAndCategories\Views\Home\Category.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"p-2 bd-highlight\">\r\n        <h2 class=\"px-5 text-warning\">Add Products:</h2>\r\n        <br>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "603f0660c7350804d723a62f9984e5364b0f24b85622", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"CategoryId\"");
                BeginWriteAttribute("value", " value=\"", 655, "\"", 680, 1);
#nullable restore
#line 22 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Assignments\ProductsAndCategories\Views\Home\Category.cshtml"
WriteAttributeValue("", 663, Model.CategoryId, 663, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <select name=\"ProductId\" class=\"form-select\">\r\n");
#nullable restore
#line 24 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Assignments\ProductsAndCategories\Views\Home\Category.cshtml"
                  
                foreach(Product p in ViewBag.allProducts)
                    {
                    if(!Model.AssociatedAt.Any(s => s.ProductId == p.ProductId))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "603f0660c7350804d723a62f9984e5364b0f24b86865", async() => {
#nullable restore
#line 29 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Assignments\ProductsAndCategories\Views\Home\Category.cshtml"
                                                             Write(p.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Assignments\ProductsAndCategories\Views\Home\Category.cshtml"
                                        WriteLiteral(p.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\finet\OneDrive\Documents\C#\C-sharp\Assignments\ProductsAndCategories\Views\Home\Category.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        <br><br><br>    \r\n            <input type=\"submit\" value=\"Add\" class=\"btn btn-warning btn-outline-dark button\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div> \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
