#pragma checksum "C:\Users\Rachel\ProyectoGeneral\Views\AMedida\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f51e272bff156631bb970fecebfed78c747dd0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AMedida_Index), @"mvc.1.0.view", @"/Views/AMedida/Index.cshtml")]
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
#line 1 "C:\Users\Rachel\ProyectoGeneral\Views\_ViewImports.cshtml"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rachel\ProyectoGeneral\Views\_ViewImports.cshtml"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Rachel\ProyectoGeneral\Views\AMedida\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f51e272bff156631bb970fecebfed78c747dd0c", @"/Views/AMedida/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37a15a183d38432e5d59901f4b5b9ca0de63cbe8", @"/Views/_ViewImports.cshtml")]
    public class Views_AMedida_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoFinal.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<!--Index catálogo-->\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Rachel\ProyectoGeneral\Views\AMedida\Index.cshtml"
 if (ViewBag.pedido == 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success mt-3\" id=\"success-alert\" role=\"alert\">\r\n        Tu pedido se ha realizado con éxito\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\Rachel\ProyectoGeneral\Views\AMedida\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container mt-5 mb-5"">
    <div class=""d-flex justify-content-center row"">
        <div class=""col-md-10"">

            <h2 class=""mb-2"">Pide tu artículo personalizado</h2>
            <hr />

            <!--Tarjeta de productos-->

            <div class=""row pb-5 mb-4"">


");
#nullable restore
#line 30 "C:\Users\Rachel\ProyectoGeneral\Views\AMedida\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-4 col-md-6 mb-4 mb-lg-0"">
                        <!-- Card-->
                        <div class=""card rounded shadow-sm border-0"">
                            <div class=""card-body p-4"">

                                <a><img");
            BeginWriteAttribute("src", " src=\"", 974, "\"", 1025, 1);
#nullable restore
#line 37 "C:\Users\Rachel\ProyectoGeneral\Views\AMedida\Index.cshtml"
WriteAttributeValue("", 980, Html.DisplayFor(modelItem => item.Thumbnail), 980, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1026, "\"", 1032, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid d-block mx-auto mb-3\"></a>\r\n                                <h5>\r\n                                    ");
#nullable restore
#line 39 "C:\Users\Rachel\ProyectoGeneral\Views\AMedida\Index.cshtml"
                               Write(Html.ActionLink(item.ProductName, "Edit",
                                        new { id = item.idProducts },
                                        new { @class = "text-dark" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                 \r\n                                </h5>\r\n                                <h5 class=\"text-secondary float-right\">$ ");
#nullable restore
#line 44 "C:\Users\Rachel\ProyectoGeneral\Views\AMedida\Index.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 48 "C:\Users\Rachel\ProyectoGeneral\Views\AMedida\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoFinal.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
