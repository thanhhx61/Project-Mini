#pragma checksum "E:\Casestudy\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3947f331f6a386912c293c81ac9ad2ac35c1e70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Add), @"mvc.1.0.view", @"/Views/Product/Add.cshtml")]
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
#line 1 "E:\Casestudy\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Casestudy\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Casestudy\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Casestudy\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop.Models.Cart;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3947f331f6a386912c293c81ac9ad2ac35c1e70", @"/Views/Product/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd61dd05d9eb8739641247982abbff3980774be5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "E:\Casestudy\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Add.cshtml"
  
    ViewBag.Title = "Thêm sản phẩm";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var lstCategory = ViewBag.lstCategory as List<OnlineShop.Entities.Category>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <div class=""row"">
        <div class=""col-md-8"">
            <div class=""card"">
                <div class=""card-header"">
                    <h5 class=""title"">Thêm mới sản phẩm</h5>
                </div>
                <div class=""card-body"">
");
#nullable restore
#line 16 "E:\Casestudy\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Add.cshtml"
                     using (Html.BeginForm("Create", "Product", FormMethod.Post, new { id = "frmValidate", enctype = "multipart/form-data" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-md-6 pr-md-1"">
                                <div class=""form-group"">
                                    <label>Tên sản phẩm</label>
                                    <input type=""text"" class=""form-control"" name=""Product_Name"" placeholder=""Nhập tên sản phẩm"">
                                </div>
                            </div>
                            <div class=""col-md-6 pr-md-1"">
                                <div class=""form-group"">
                                    <label>Thuộc danh mục</label>
                                    <select class=""form-control"" name=""Category_ID"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3947f331f6a386912c293c81ac9ad2ac35c1e705538", async() => {
                WriteLiteral("Chọn danh mục sản phẩm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 30 "E:\Casestudy\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Add.cshtml"
                                         foreach (var item in lstCategory)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3947f331f6a386912c293c81ac9ad2ac35c1e707070", async() => {
#nullable restore
#line 32 "E:\Casestudy\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Add.cshtml"
                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "E:\Casestudy\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Add.cshtml"
                                               WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 33 "E:\Casestudy\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Add.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </select>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6 pr-md-1"">
                                <div class=""form-group"">
                                    <label>Giá gốc</label>
                                    <input type=""number"" min=""5000"" name=""Promotion_Price"" class=""form-control"" placeholder=""Nhập giá gốc"">
                                </div>
                            </div>
                            <div class=""col-md-6 pl-md-1"">
                                <div class=""form-group"">
                                    <label>Giá khuyến mãi</label>
                                    <input type=""number"" min=""5000"" name=""Price"" class=""form-control"" placeholder=""Nhập giá khuyến mãi"">
                                </div>
                            </div>
                        </div>
                  ");
            WriteLiteral(@"      <div class=""row"">
                            <div class=""col-md-6 pr-md-1"">
                                <div class=""form-group"">
                                    <label style=""padding-right: 225px;"">Hình ảnh sản phẩm</label>
                                    <label for=""file-upload"" class=""custom-file-upload"">
                                        <i class=""fa fa-upload""></i> Chọn hình ảnh sản phẩm
                                    </label>
                                    <input id=""file-upload"" name=""Image"" type=""file"" style=""display:none;"" accept=""image/*"">
                                </div>
                            </div>
                            <div class=""col-md-6 px-md-1"">
                                <div class=""form-group"">
                                    <label>Số lượng</label>
                                    <input type=""number"" min=""1"" name=""Quantity"" class=""form-control"" placeholder=""Nhập số lượng sản phẩm"">
                                </div>
     ");
            WriteLiteral(@"                       </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-4 pr-md-1"">
                            </div>
                            <div class=""col-md-4 px-md-1"">
                                <button type=""submit"" class=""btn btn-fill btn-primary"">Thêm mới</button>
                            </div>
                            <div class=""col-md-4 pr-md-1"">
                            </div>
                        </div>
");
#nullable restore
#line 78 "E:\Casestudy\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Add.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"card-footer\">\n                    <a href=\"/Product\" class=\"btn btn-fill btn-default\">Quay lại</a>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("jsAdmin", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $('#file-upload').change(function() {
              var i = $(this).prev('label').clone();
              var file = '<i class=""fa fa-upload""></i>' + $('#file-upload')[0].files[0].name;
              $(this).prev('label').empty();
              $(this).prev('label').append(file);
            });

            // add the rule here
            $.validator.addMethod(""select_validate"", function (value, element, arg) {
                return arg !== value;
            }, ""Value must not equal arg."");
            //Khi bàn phím được nhấn và thả ra thì sẽ chạy phương thức này
            $(""#frmValidate"").validate({
                rules: {
                    Product_Name: ""required"",
                    Promotion_Price: ""required"",
                    //Price: ""required"",
                    Quantity: ""required"",
                    Category_ID: { select_validate: """" },
                    Image: { select_validate: """" }
                },
           ");
                WriteLiteral(@"     messages: {
                    Product_Name: ""Vui lòng nhập tên sản phẩm"",
                    Promotion_Price: ""Vui lòng nhập giá gốc"",
                    //Price: ""Vui lòng nhập giá khuyến mãi"",
                    Quantity: ""Vui lòng số lượng sản phẩm"",
                    Category_ID:{ select_validate: ""Bạn chưa chọn danh mục sản phẩm!"" },
                    Image: ""Vui lòng chọn hình ảnh""
                }
            });
        });
    </script>

");
            }
            );
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
