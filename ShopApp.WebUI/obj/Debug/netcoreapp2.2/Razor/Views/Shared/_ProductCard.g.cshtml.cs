#pragma checksum "C:\Users\bkgorun\Desktop\ShopApp\ShopApp.WebUI\Views\Shared\_ProductCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e289b6be5f8211a31e7bbc5562e418026ee33f7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductCard), @"mvc.1.0.view", @"/Views/Shared/_ProductCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ProductCard.cshtml", typeof(AspNetCore.Views_Shared__ProductCard))]
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
#line 2 "C:\Users\bkgorun\Desktop\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#line 3 "C:\Users\bkgorun\Desktop\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e289b6be5f8211a31e7bbc5562e418026ee33f7e", @"/Views/Shared/_ProductCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347b7be2f8b3cec51ab783c274c53a46b5c62de2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:400px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 96, true);
            WriteLiteral("<div class=\"col-md-4 \">\r\n    <br />\r\n    <div class=\"card ml-3\" style=\"width: 18rem;\">\r\n        ");
            EndContext();
            BeginContext(112, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e289b6be5f8211a31e7bbc5562e418026ee33f7e4395", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 144, "~/lib/img/", 144, 10, true);
#line 5 "C:\Users\bkgorun\Desktop\ShopApp\ShopApp.WebUI\Views\Shared\_ProductCard.cshtml"
AddHtmlAttributeValue("", 154, Model.ImageUrl, 154, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(202, 70, true);
            WriteLiteral("\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(273, 10, false);
#line 7 "C:\Users\bkgorun\Desktop\ShopApp\ShopApp.WebUI\Views\Shared\_ProductCard.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(283, 46, true);
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">Fiyat:");
            EndContext();
            BeginContext(330, 11, false);
#line 8 "C:\Users\bkgorun\Desktop\ShopApp\ShopApp.WebUI\Views\Shared\_ProductCard.cshtml"
                                  Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(341, 20, true);
            WriteLiteral("</p>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 361, "\"", 391, 2);
            WriteAttributeValue("", 368, "/Shop/Details/", 368, 14, true);
#line 9 "C:\Users\bkgorun\Desktop\ShopApp\ShopApp.WebUI\Views\Shared\_ProductCard.cshtml"
WriteAttributeValue("", 382, Model.Id, 382, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(392, 141, true);
            WriteLiteral(" class=\"btn btn-primary\">Detay</a>\r\n            <a href=\"#\" class=\"btn btn-primary ml-3 \">Add To Card</a>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
