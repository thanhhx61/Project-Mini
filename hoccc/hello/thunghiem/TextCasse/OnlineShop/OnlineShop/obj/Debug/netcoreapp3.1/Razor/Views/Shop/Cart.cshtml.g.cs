#pragma checksum "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a19164f74e7a386b49046ee940a7aeff86271396"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Cart), @"mvc.1.0.view", @"/Views/Shop/Cart.cshtml")]
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
#line 1 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop.Models.Cart;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a19164f74e7a386b49046ee940a7aeff86271396", @"/Views/Shop/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd61dd05d9eb8739641247982abbff3980774be5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn continue-shop"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("coupon-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
  
    ViewBag.Title = "Cart detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
 if (Model.Count > 0)
{
    decimal totalAmount = 0;
    decimal totalpromo = 0;
    //int orderNumber = 1;
    decimal Saleprice = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""shopping-cart spad"">
        <div class=""container"">
            <h2>Cart Detail</h2>
            <div class=""row"">
                <div class=""table-responsive-"">
                    <div class=""cart-table"">
                        <table style=""width:1000px"">
                            <thead>
                                <tr>
                                    <th>Photo</th>
                                    <th>Product name</th>
                                    <th>Price</th>
                                    <th>Promotion Price</th>
                                    <th>Amount</th>
                                    <th>Total</th>

                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 34 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
                                 foreach (var cartitem in Model)
                                {
                                    var amount = cartitem.Quantity * cartitem.Product.Promotion_Price;
                                    totalAmount += amount;
                                    var amoutPromotion = cartitem.Quantity * cartitem.Product.Priceproduct;
                                    totalpromo += amoutPromotion;
                                    Saleprice = totalAmount - totalpromo;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"cart-pic first-row\"><img");
            BeginWriteAttribute("src", " src=\"", 1703, "\"", 1748, 2);
            WriteAttributeValue("", 1709, "..", 1709, 2, true);
#nullable restore
#line 42 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
WriteAttributeValue("", 1711, Url.Content(@cartitem.Product.Photo), 1711, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1749, "\"", 1784, 1);
#nullable restore
#line 42 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
WriteAttributeValue("", 1755, cartitem.Product.ProdcutName, 1755, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                        <td class=\"p-price first-row\">\r\n                                            ");
#nullable restore
#line 44 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
                                       Write(cartitem.Product.ProdcutName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"p-price first-row\">");
#nullable restore
#line 46 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
                                                                  Write(cartitem.Product.Promotion_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"p-price first-row\">");
#nullable restore
#line 47 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
                                                                  Write(cartitem.Product.Priceproduct);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        <td class=""qua-col first-row"">
                                            <div class=""quantity"">
                                                <div class=""pro-qty"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a19164f74e7a386b49046ee940a7aeff8627139610998", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 51 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => cartitem.Quantity);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
AddHtmlAttributeValue("", 2513, $"quantity-{cartitem.Product.ProductId}", 2513, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td class=\"total-price first-row\">");
#nullable restore
#line 55 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
                                                                      Write(amount.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                                        <td class=\" close-td first-row updatecartitem \" data-productId=\"");
#nullable restore
#line 58 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
                                                                                                   Write(cartitem.Product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                            <h2 class=\"btn btn-info\">+</h2>\r\n                                        </td>\r\n\r\n                                        <td class=\"close-td first-row\">\r\n                                            <i></i>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a19164f74e7a386b49046ee940a7aeff8627139614377", async() => {
                WriteLiteral("X");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ProductId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
                                                                                                             WriteLiteral(cartitem.Product.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProductId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 67 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </tbody>
                        </table>
                    </div>
                    <div class=""row"">
                        <div class=""col-lg-4"">
                            <div class=""cart-buttons"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a19164f74e7a386b49046ee940a7aeff8627139617533", async() => {
                WriteLiteral("Continue shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                            <div class=\"discount-coupon\">\r\n                                <h6>Discount Codes</h6>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a19164f74e7a386b49046ee940a7aeff8627139619185", async() => {
                WriteLiteral("\r\n                                    <input type=\"text\" placeholder=\"Enter your codes\">\r\n                                    <button type=\"submit\" class=\"site-btn coupon-btn\">Apply</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-lg-4 offset-lg-4"">
                            <div class=""proceed-checkout"">
                                <ul>
                                    <li class=""subtotal"">Promotion total <span>");
#nullable restore
#line 89 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
                                                                           Write(totalpromo.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                    <li class=\"cart-total\">Total <span>");
#nullable restore
#line 90 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
                                                                   Write(Saleprice.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
                                </ul>
                                <a href=""#"" class=""proceed-btn"">PROCEED TO CHECK OUT</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
");
            DefineSection("jsAdmin", async() => {
                WriteLiteral(@"
        <script>
          $(document).ready(function () {
              $("".updatecartitem"").click(function (event) {
                  event.preventDefault();
                  var productId = $(this).attr(""data-productId"");
                  var quantity = $(""#quantity-"" + productId).val();
                  $.ajax({
                      type: ""POST"",
                      url:""");
#nullable restore
#line 110 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
                      Write(Url.RouteUrl("updatecart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                      data: {
                          productId: productId,
                          quantity:quantity
                      },
                      success: function (result) {
                          window.location.href = """);
#nullable restore
#line 116 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
                                             Write(Url.RouteUrl(@"\Shop\Cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                      }\r\n                  });\r\n              });\r\n          });\r\n        </script>\r\n    ");
            }
            );
#nullable restore
#line 122 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
     

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger\">Cart is empty</p>\r\n    <div class=\"cart-buttons\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a19164f74e7a386b49046ee940a7aeff8627139623884", async() => {
                WriteLiteral("Continue shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 132 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Shop\Cart.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
