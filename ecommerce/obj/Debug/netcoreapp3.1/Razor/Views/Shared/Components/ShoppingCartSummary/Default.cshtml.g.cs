#pragma checksum "/home/facundo/code/pluralsight/asp.core/Ecommerce/ecommerce/Views/Shared/Components/ShoppingCartSummary/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916a21fbf932f9cef64adf14d8deeeab52a923d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShoppingCartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ShoppingCartSummary/Default.cshtml")]
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
#line 1 "/home/facundo/code/pluralsight/asp.core/Ecommerce/ecommerce/Views/_ViewImports.cshtml"
using ecommerce.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/facundo/code/pluralsight/asp.core/Ecommerce/ecommerce/Views/_ViewImports.cshtml"
using ecommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/facundo/code/pluralsight/asp.core/Ecommerce/ecommerce/Views/_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/facundo/code/pluralsight/asp.core/Ecommerce/ecommerce/Views/_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916a21fbf932f9cef64adf14d8deeeab52a923d2", @"/Views/Shared/Components/ShoppingCartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8afb10eff7446720d662630955c7a6d5c2b821d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ShoppingCartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/facundo/code/pluralsight/asp.core/Ecommerce/ecommerce/Views/Shared/Components/ShoppingCartSummary/Default.cshtml"
 if (Model.ShoppingCart.ShoppingCartItems.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li class=\"nav-item\">\n    <a class=\"nav-link\">\n      <span>Cart Products: </span>\n      <span class=\"cart-status\">\n        ");
#nullable restore
#line 9 "/home/facundo/code/pluralsight/asp.core/Ecommerce/ecommerce/Views/Shared/Components/ShoppingCartSummary/Default.cshtml"
   Write(Model.ShoppingCart.ShoppingCartItems.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      </span>\n    </a>\n  </li>\n");
#nullable restore
#line 13 "/home/facundo/code/pluralsight/asp.core/Ecommerce/ecommerce/Views/Shared/Components/ShoppingCartSummary/Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
