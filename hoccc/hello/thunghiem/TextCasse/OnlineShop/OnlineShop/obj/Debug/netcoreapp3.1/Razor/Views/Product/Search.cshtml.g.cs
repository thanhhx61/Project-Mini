#pragma checksum "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab4d7b355ca23bf5ab278779cce573f11ae48b62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Search), @"mvc.1.0.view", @"/Views/Product/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab4d7b355ca23bf5ab278779cce573f11ae48b62", @"/Views/Product/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd61dd05d9eb8739641247982abbff3980774be5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OnlineShop.Entities.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Product/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
  
    ViewBag.Title = "Tìm kiếm";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int dem = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"content\">\n    <div class=\"row\">\n");
#nullable restore
#line 11 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
         if (TempData["add_success"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success\" id=\"AlertBox\">\n                ");
#nullable restore
#line 14 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
           Write(TempData["add_success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 16 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card "">
                <div class=""card-header"">
                    <div class=""col-md-3 pull-left"">
                        <h4 class=""card-title"">Tìm kiếm : <span>");
#nullable restore
#line 23 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
                                                           Write(ViewBag.KeyWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\n                    </div>\n                    <div class=\"col-md-6 pull-left\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab4d7b355ca23bf5ab278779cce573f11ae48b626121", async() => {
                WriteLiteral(@"
                            <div class=""input-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Tìm kiếm sản phẩm..."" name=""keyword"" id=""txtKeyword"" required>
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-outline-secondary"" type=""submit""><i class=""fa fa-search""></i></button>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""col-md-3 pull-right"">
                        <a href=""/Product/Add"" class=""btn btn-fill btn-primary""><i class=""fa fa-plus""></i>Thêm mới</a>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table tablesorter """);
            BeginWriteAttribute("id", " id=\"", 1705, "\"", 1710, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <thead class="" text-primary"">
                                <tr>
                                    <th>#</th>
                                    <th>Tên sản phẩm</th>
                                    <th>Hình ảnh</th>
                                    <th>Giá gốc</th>
                                    <th>Giá km</th>
                                    <th>Số lượng tồn</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 54 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td>");
#nullable restore
#line 57 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
                                       Write(dem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 58 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
                                       Write(item.Product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td><img");
            BeginWriteAttribute("src", " src=\"", 2593, "\"", 2613, 2);
            WriteAttributeValue("", 2599, "../", 2599, 3, true);
#nullable restore
#line 59 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
WriteAttributeValue("", 2602, item.Image, 2602, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2614, "\"", 2620, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"110px\" /></td>\n                                        <td>");
#nullable restore
#line 60 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
                                       Write(item.Promotion_Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 61 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
                                         if (item.Price != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>");
#nullable restore
#line 63 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
                                           Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 64 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td></td>\n");
#nullable restore
#line 68 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        <td>");
#nullable restore
#line 70 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3298, "\"", 3327, 2);
            WriteAttributeValue("", 3305, "/Product/Edit/", 3305, 14, true);
#nullable restore
#line 72 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
WriteAttributeValue("", 3319, item.ID, 3319, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\" title=\"Sửa sản phẩm\"><i class=\"fa fa-edit\"></i></a>\n                                            <button class=\"btn btn-danger btnDelete\" data-id=\"");
#nullable restore
#line 73 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
                                                                                         Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Xóa sản phẩm\"><i class=\"fa fa-times\"></i></button>\n                                        </td>\n                                    </tr>\n");
#nullable restore
#line 76 "E:\hoccc\hello\thunghiem\TextCasse\OnlineShop\OnlineShop\Views\Product\Search.cshtml"
                                    dem++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\n                        </table>\n");
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("jsAdmin", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(function () {
            //nếu không có thao tác gì thì ẩn đi
            $('#AlertBox').removeClass('hide');

            //Sau khi hiển thị lên thì delay 1s và cuộn lên trên sử dụng slideup
            $('#AlertBox').delay(2000).slideUp(500);


            $('.btnDelete').off('click').on('click', function () {
                const notice = PNotify.notice({
                    title: 'Thông báo',
                    text: 'Bạn thật sự muốn xóa?',
                    icon: 'fa fa-question-circle',
                    width: '360px',
                    minHeight: '110px',
                    hide: false,
                    closer: false,
                    sticker: false,
                    destroy: true,
                    stack: new PNotify.Stack({
                        dir1: 'down',
                        modal: true,
                        firstpos1: 25,
                        overlayClose: false
                    }),
                    modules");
                WriteLiteral(@": new Map([
                        ...PNotify.defaultModules,
                        [PNotifyConfirm, {
                            confirm: true
                        }]
                    ])
                });

                notice.on('pnotify:confirm', () =>
                    $.ajax({
                        data: { ID: $(this).data('id') },
                        url: '/Product/Delete',
                        dataType: 'Json',
                        type: 'POST',
                        success: function (res) {
                            if (res.status == true) {
                                window.location.href = ""/Product"";
                                PNotify.success({
                                    title: 'THÔNG BÁO!!',
                                    text: 'Xóa sản phẩm thành công.'
                                });
                            } else {

                                PNotify.error({
                                    title: 'THÔNG BÁO!!',
           ");
                WriteLiteral(@"                         text: 'Xóa sản phẩm KHÔNG thành công. Bạn vui lòng xóa chi tiết sản phẩm trước.'
                                });
                            }
                        }
                    })

                );


            });
        });

         var common = {
            init: function () {
                common.registerEvent();
            },
            registerEvent: function () {
                $(""#txtKeyword"").autocomplete({
                    minLength: 0,
                    source: function (request, response) {
                        $.ajax({
                            url: ""/Product/ListName"",//Link lấy dữ liệu gợi ý
                            dataType: ""json"",
                            data: {
                                q: request.term
                            },
                            success: function (res) {
                                response(res.data);
                                //response($.map(data, function (item) {
        ");
                WriteLiteral(@"                        //    return {
                                //        value: item.Product_Name,
                                //        label: item.Image
                                //    }
                                //}));
                            }
                        });
                    },
                    focus: function (event, ui) {
                        $(""#txtKeyword"").val(ui.item.label);
                        return false;
                    },
                    select: function (event, ui) {
                        $(""#txtKeyword"").val(ui.item.label);
                        //$(""#project-id"").val(ui.item.value);
                        //$(""#project-description"").html(ui.item.desc);
                        //$(""#project-icon"").attr(""src"", ""images/"" + ui.item.icon);

                        return false;
                    }
                })
                    .autocomplete(""instance"")._renderItem = function (ul, item) {
                        return $");
                WriteLiteral(@"(""<li>"")
                            //.append(""<div>"" + item.value + ""<br>"" + item.label + ""</div>"")
                            .append(""<div>"" + item.value + ""</div>"")
                            .appendTo(ul);
                    };
            }
        }
        common.init();
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OnlineShop.Entities.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591