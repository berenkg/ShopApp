#pragma checksum "C:\Users\bkgorun\Desktop\ShopApp\ShopApp.WebUI\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "508e59a9074161549ebb451f81b3ce0d2fb9958b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_navbar.cshtml", typeof(AspNetCore.Views_Shared__navbar))]
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
#line 2 "C:\Users\bkgorun\Desktop\ShopApp\ShopApp.WebUI\Views\Shared\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#line 3 "C:\Users\bkgorun\Desktop\ShopApp\ShopApp.WebUI\Views\Shared\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"508e59a9074161549ebb451f81b3ce0d2fb9958b", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21ef84573e7d7c451bd440542b6e841681414892", @"/Views/Shared/_ViewImports.cshtml")]
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2523, true);
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg navbar-light bg-primary fixed-top navbar-dark"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""#"">ShopApp</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""#"">Home <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/Shop/Index"">Product <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Cart <span class=""sr-on");
            WriteLiteral(@"ly"">(current)</span></a>
                </li>
                <li class=""nav-item "">
                    <a class=""nav-link"" href=""#"">Orders <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item "">
                    <a class=""nav-link"" href=""#"">Add Product <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item "">
                    <a class=""nav-link"" href=""#"">Admin Prdocuts <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item "">
                    <a class=""nav-link"" href=""#"">Add Categories <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item "">
                    <a class=""nav-link"" href=""#"">Admin Categories <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item "">
            </ul>
            <ul class=""navbar-nav mr-auto"">
                <a class=");
            WriteLiteral(@"""nav-link"" href=""#"">Logout<span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item "">
                    <a class=""nav-link"" href=""#"">Login<span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item "">
                    <a class=""nav-link"" href=""#"">Register<span class=""sr-only"">(current)</span></a>
                </li>


            </ul>
        </div>
    </div>
</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591