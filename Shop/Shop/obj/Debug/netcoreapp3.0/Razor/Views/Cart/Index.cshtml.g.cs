#pragma checksum "C:\Other\lessons\c#\AspLearn\Shop\Shop\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de4a9142b5fd036dd4636a1b8abfdf983fa445ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de4a9142b5fd036dd4636a1b8abfdf983fa445ed", @"/Views/Cart/Index.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.ViewModels.ShopCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Other\lessons\c#\AspLearn\Shop\Shop\Views\Cart\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<div class=\"container\">\r\n");
#nullable restore
#line 10 "C:\Other\lessons\c#\AspLearn\Shop\Shop\Views\Cart\Index.cshtml"
     foreach (var item in Model.ShopCart.ShopItems)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning mt-3\">\r\n            <b>Автомобиль:</b> ");
#nullable restore
#line 13 "C:\Other\lessons\c#\AspLearn\Shop\Shop\Views\Cart\Index.cshtml"
                          Write(item.Car.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            <b>Цена:</b> ");
#nullable restore
#line 14 "C:\Other\lessons\c#\AspLearn\Shop\Shop\Views\Cart\Index.cshtml"
                    Write(item.Car.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Other\lessons\c#\AspLearn\Shop\Shop\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n    <div class=\"btn btn-dark\" asp-controller = \"Order\">Оплатить</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.ViewModels.ShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
