#pragma checksum "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "950e800574f95c3423168fbb7af0643c99af252d"
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
#nullable restore
#line 1 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\_ViewImports.cshtml"
using Assignment.CustomerSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\_ViewImports.cshtml"
using Assignment.CustomerSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"950e800574f95c3423168fbb7af0643c99af252d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"410b674406e4913182a5ed418c61463ee897c59f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assignment.Shared.ProductRespone>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""single-product-slider mt-5"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-6 text-center"">
                <div class=""section-title"">
                    <h1>Our Products</h1>
                </div>
            </div>
        </div>
        <div class=""row"">
            <!-- single product -->
");
#nullable restore
#line 19 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.Product)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-6\">\r\n                    <div class=\"single-product\">\r\n                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 698, "\"", 720, 1);
#nullable restore
#line 23 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 704, item.ProductImg, 704, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 721, "\"", 727, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-details\">\r\n                            <h6>\r\n                                ");
#nullable restore
#line 26 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
                           Write(item.NameProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h6>\r\n                            <div class=\"price\">\r\n                                <h6>");
#nullable restore
#line 29 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <p>");
#nullable restore
#line 31 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <div class=\"prd-bottom\">\r\n\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1189, "\"", 1196, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"social-info\">\r\n                                    <span class=\"ti-bag\"></span>\r\n                                    <p class=\"hover-text\">add to bag</p>\r\n                                </a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1432, "\"", 1439, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"social-info\">\r\n                                    <span class=\"lnr lnr-heart\"></span>\r\n                                    <p class=\"hover-text\">Wishlist</p>\r\n                                </a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1680, "\"", 1687, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"social-info\">\r\n                                    <span class=\"lnr lnr-sync\"></span>\r\n                                    <p class=\"hover-text\">compare</p>\r\n                                </a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1926, "\"", 1933, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""social-info"">
                                    <span class=""lnr lnr-move""></span>
                                    <p class=""hover-text"">view more</p>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 54 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assignment.Shared.ProductRespone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
