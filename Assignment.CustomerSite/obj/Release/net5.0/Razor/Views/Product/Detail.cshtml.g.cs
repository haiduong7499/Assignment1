#pragma checksum "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41df1d5273992b4f84333fc13475ca68ac8c399d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#nullable restore
#line 3 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\_ViewImports.cshtml"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41df1d5273992b4f84333fc13475ca68ac8c399d", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45384b9193ea96b127fb00e8944c63baf981dbd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductRespone>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("join"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41df1d5273992b4f84333fc13475ca68ac8c399d5277", async() => {
                WriteLiteral("<img class=\"img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 217, "\"", 240, 1);
#nullable restore
#line 5 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
WriteAttributeValue("", 223, Model.ProductImg, 223, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 241, "\"", 265, 1);
#nullable restore
#line 5 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
WriteAttributeValue("", 247, Model.NameProduct, 247, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 5 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
                                                              WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-lg-5 offset-lg-1\">\r\n            <div class=\"s_product_text\">\r\n                <h3>");
#nullable restore
#line 9 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
               Write(Model.NameProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h2>");
#nullable restore
#line 10 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
               Write(Convert.ToDecimal(Model.Price).ToString("#,##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</h2>\r\n                <ul class=\"list\">\r\n                    <li><a class=\"active\" href=\"#\"><span>Category</span> : ");
#nullable restore
#line 12 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
                                                                      Write(Model.NameCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    <li><a href=\"#\"><span>Availibility</span> : In Stock</a></li>\r\n                </ul>\r\n                <p>\r\n                    ");
#nullable restore
#line 16 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
                <div class=""card_area d-flex align-items-center"">
                    <a class=""primary-btn"" href=""#"">Add to Cart</a>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-6"">
        <div class=""review_box"">
            <h4>Add a Review</h4>
            <p>Your Rating:</p>
            <h3>
");
#nullable restore
#line 29 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
                 for (int i = 0; i < Model.Rated; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i class=\"ion-android-star\" style=\"color: #ffdd59\"></i>\r\n");
#nullable restore
#line 32 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </h3>\r\n            <h2 class=\"h3\">What do you think? (#");
#nullable restore
#line 34 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
                                           Write(ViewBag.rateCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h2>\r\n            <div class=\"wrapper\">\r\n                <div class=\"content\">\r\n");
#nullable restore
#line 37 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
                     foreach (var review in ViewBag.rate)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
                   Write(await Component.InvokeAsync("Rating", review));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
                                                                      ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41df1d5273992b4f84333fc13475ca68ac8c399d12274", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""rate"">
                            <input type=""radio"" id=""star5"" name=""rate"" value=""5"" />
                            <label for=""star5"" title=""text"">5 stars</label>
                            <input type=""radio"" id=""star4"" name=""rate"" value=""4"" />
                            <label for=""star4"" title=""text"">4 stars</label>
                            <input type=""radio"" id=""star3"" name=""rate"" value=""3"" />
                            <label for=""star3"" title=""text"">3 stars</label>
                            <input type=""radio"" id=""star2"" name=""rate"" value=""2"" />
                            <label for=""star2"" title=""text"">2 stars</label>
                            <input type=""radio"" id=""star1"" name=""rate"" value=""1"" />
                            <label for=""star1"" title=""text"">1 star</label>
                        </div>
                    </div>
                    <div clas");
                WriteLiteral("s=\"col-sm-6\">\r\n                        <input type=\"text\" name=\"userName\"");
                BeginWriteAttribute("value", " value=\"", 2935, "\"", 2943, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Name\" required class=\"form-control\" />\r\n                        <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 3059, "\"", 3083, 1);
#nullable restore
#line 62 "E:\Year4\NashTech\New folder\Assignment1\Assignment.CustomerSite\Views\Product\Detail.cshtml"
WriteAttributeValue("", 3067, Model.ProductId, 3067, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        <br>
                    </div>
                    <div class=""col-sm-12"">
                        <textarea name=""comments"" placeholder=""Type here"" required class=""form-control"" rows=""5""></textarea>
                        <br>
                    </div>
                    <div class=""col-sm-12"">
                        <div class=""align-center"">
                            <br>
                            <button type=""submit"" class=""btn btn-primary btn-sm""> <i class=""ion-android-send""></i> Send</button>
                            <button type=""button"" class=""btn btn-primary btn-sm"" data-dismiss=""modal""> <i class=""ion-android-share""></i> No, thanks </button>
                            <br><br>
                        </div>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductRespone> Html { get; private set; }
    }
}
#pragma warning restore 1591