#pragma checksum "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\Fragrances\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a9f12f44ac680e975d95f1b2237c2745c27183f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fragrances_Details), @"mvc.1.0.view", @"/Views/Fragrances/Details.cshtml")]
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
#line 1 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\_ViewImports.cshtml"
using FragranceProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\_ViewImports.cshtml"
using FragranceProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\_ViewImports.cshtml"
using FragranceProject.Models.Fragrances;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\_ViewImports.cshtml"
using FragranceProject.Models.Home;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a9f12f44ac680e975d95f1b2237c2745c27183f", @"/Views/Fragrances/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"573513729475d889a94b0b7b0f5729a2bbdada82", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Fragrances_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FragranceListingViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\Fragrances\Details.cshtml"
  
    ViewBag.Title = "Details - ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"mb-5\"></div>\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"card text-myWhite\">\r\n\r\n        <div class=\"card-body bg-transparent\">\r\n            <div class=\"row\">\r\n                <div class=\"col-5\">\r\n                    <img class=\"mb-3\"");
            BeginWriteAttribute("src", " src=\"", 331, "\"", 352, 1);
#nullable restore
#line 15 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\Fragrances\Details.cshtml"
WriteAttributeValue("", 337, Model.ImageUrl, 337, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"500\"");
            BeginWriteAttribute("alt", " alt=\"", 366, "\"", 396, 3);
#nullable restore
#line 15 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\Fragrances\Details.cshtml"
WriteAttributeValue("", 372, Model.Name, 372, 11, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\Fragrances\Details.cshtml"
WriteAttributeValue(" ", 383, Model.Year, 384, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 395, "", 396, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col text-myWhite\">\r\n                    <h3 class=\"mb-3\" style=\"color: black\">");
#nullable restore
#line 18 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\Fragrances\Details.cshtml"
                                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 18 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\Fragrances\Details.cshtml"
                                                                  Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h3>\r\n                    <p style=\"color: black\">");
#nullable restore
#line 19 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\Fragrances\Details.cshtml"
                                       Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p style=\"color: black\">Type - ");
#nullable restore
#line 20 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\Fragrances\Details.cshtml"
                                              Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <p style=""color: black"">Top Notes - </p>
                    <p style=""color: black"">Middle Notes - </p>
                    <p style=""color: black"">Base Notes - </p>

                    <div class=""mt-auto mb-0"" style=""position: absolute; bottom: 0"">
                        <h4 class=""mb-3"" style=""color: black"">Summary</h4>
                        <h5 class=""card-title mb-4 text-left"" style=""color: black"">");
#nullable restore
#line 27 "C:\Users\Svetlio\Documents\GitHub\ASP.NET-Core-Project-Fragrance\FragranceProject\Views\Fragrances\Details.cshtml"
                                                                              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FragranceListingViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
