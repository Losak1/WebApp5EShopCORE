#pragma checksum "/Users/losak/Projects/WebApp5EShopCORE/WebApp5EMVC/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4537729e6994dddb992d7f03761a1e3ca69fe82c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4537729e6994dddb992d7f03761a1e3ca69fe82c", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp5EMVC.Models.View.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/losak/Projects/WebApp5EShopCORE/WebApp5EMVC/Views/Home/Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_LayoutBasePage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Index</h2>\n<table>\n");
#nullable restore
#line 9 "/Users/losak/Projects/WebApp5EShopCORE/WebApp5EMVC/Views/Home/Index.cshtml"
     foreach (var p in Model.Prodotti)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 226, "\"", 285, 1);
#nullable restore
#line 12 "/Users/losak/Projects/WebApp5EShopCORE/WebApp5EMVC/Views/Home/Index.cshtml"
WriteAttributeValue("", 233, WebApp5EMVC.Helpers.PathHelper.GetProdottoUrl(p.Id), 233, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Dettagli</a></td>\n        <td>");
#nullable restore
#line 13 "/Users/losak/Projects/WebApp5EShopCORE/WebApp5EMVC/Views/Home/Index.cshtml"
       Write(p.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 14 "/Users/losak/Projects/WebApp5EShopCORE/WebApp5EMVC/Views/Home/Index.cshtml"
       Write(p.Descrizione);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td><img");
            BeginWriteAttribute("src", " src=\"", 378, "\"", 439, 1);
#nullable restore
#line 15 "/Users/losak/Projects/WebApp5EShopCORE/WebApp5EMVC/Views/Home/Index.cshtml"
WriteAttributeValue("", 384, WebApp5EMVC.Helpers.PathHelper.GetProdottoImagePath(p), 384, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\" height:50px; width:50px\"></td>\n        <td>");
#nullable restore
#line 16 "/Users/losak/Projects/WebApp5EShopCORE/WebApp5EMVC/Views/Home/Index.cshtml"
       Write(p.Prezzo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 17 "/Users/losak/Projects/WebApp5EShopCORE/WebApp5EMVC/Views/Home/Index.cshtml"
       Write(p.Quantita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 18 "/Users/losak/Projects/WebApp5EShopCORE/WebApp5EMVC/Views/Home/Index.cshtml"
       Write(p.Creazione);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 19 "/Users/losak/Projects/WebApp5EShopCORE/WebApp5EMVC/Views/Home/Index.cshtml"
       Write(p.Modifica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>    \n");
#nullable restore
#line 21 "/Users/losak/Projects/WebApp5EShopCORE/WebApp5EMVC/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp5EMVC.Models.View.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
