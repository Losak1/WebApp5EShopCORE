#pragma checksum "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77de56210b4f41371aaf69c8bf930ba3bcc58527"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77de56210b4f41371aaf69c8bf930ba3bcc58527", @"/Views/Home/Detail.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp5EMVC.Models.View.DetailView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
  
    Layout = "~/Views/Shared/_LayoutBasePage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
 if (Model.Prodotto != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 8 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
   Write(Model.Prodotto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <img");
            BeginWriteAttribute("src", " src=\"", 175, "\"", 205, 1);
#nullable restore
#line 9 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
WriteAttributeValue("", 181, Model.Prodotto.Immagine, 181, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n    <p>");
#nullable restore
#line 10 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
  Write(Model.Prodotto.Descrizione);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>");
#nullable restore
#line 11 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
  Write(Model.Prodotto.Prezzo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>");
#nullable restore
#line 12 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
  Write(Model.Prodotto.Quantita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>");
#nullable restore
#line 13 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
  Write(Model.Prodotto.Creazione);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>");
#nullable restore
#line 14 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
  Write(Model.Prodotto.Modifica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 15 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 18 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <p>");
#nullable restore
#line 19 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
  Write(Model.MessaggioErrore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 20 "/Users/losak/Projects/WebApp5EMVC/WebApp5EMVC/Views/Home/Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp5EMVC.Models.View.DetailView> Html { get; private set; }
    }
}
#pragma warning restore 1591
