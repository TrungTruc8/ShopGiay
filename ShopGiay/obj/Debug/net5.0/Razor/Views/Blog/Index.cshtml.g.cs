#pragma checksum "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dac7aa39021b613dae57a25fd4d16c36e38afd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "E:\ShopGiay\ShopGiay\Views\_ViewImports.cshtml"
using ShopGiay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ShopGiay\ShopGiay\Views\_ViewImports.cshtml"
using ShopGiay.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dac7aa39021b613dae57a25fd4d16c36e38afd8", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd452c5f67e48a959597e4e8a38cee4ceb59688", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<ShopGiay.Models.TinDang>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
  
    ViewData["TiTle"] = "Blog - " + ViewBag.CurrentPage;
    Layout = "~/Views/Shared/_Layout.cshtml";
    int PageCurrent = ViewBag.CurrentPage;
    int PageNext = PageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"main-content\">\r\n    \r\n    <div class=\"blog-area blog-column-2 section-space-y-axis-100\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 15 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
                 if (Model != null && Model.Count() > 0)
                {
                    foreach (var item in Model)
                    {
                        string url = $"/tin-tuc/{item.Alias}-{item.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6\">\r\n                            <div class=\"blog-item\">\r\n                                <div class=\"blog-img img-zoom-effect\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 891, "\"", 902, 1);
#nullable restore
#line 23 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
WriteAttributeValue("", 898, url, 898, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2dac7aa39021b613dae57a25fd4d16c36e38afd85732", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 998, "~/images/tindangs/", 998, 18, true);
#nullable restore
#line 24 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1016, item.Thumb, 1016, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1034, item.Title, 1034, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </a>
                                </div>
                                <div class=""blog-content"">
                                    <div class=""blog-meta text-dim-gray pb-3"">
                                        <ul>
                                            <li class=""date""><i class=""fa fa-calendar-o me-2""></i>");
#nullable restore
#line 30 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
                                                                                             Write(item.CreatedDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                            <li>
                                                <span class=""comments me-3"">
                                                    <a href=""javascript:void(0)"">2 Comments</a>
                                                </span>
                                                <span class=""link-share"">
                                                    <a href=""javascript:void(0)"">Share</a>
                                                </span>
                                            </li>
                                        </ul>
                                    </div>
                                    <h5 class=""title mb-4"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2216, "\"", 2227, 1);
#nullable restore
#line 42 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2223, url, 2223, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                    </h5>
                                    <p class=""short-desc mb-5""></p>
                                    <div class=""button-wrap"">
                                        <a class=""btn btn-custom-size lg-size btn-dark rounded-0""");
            BeginWriteAttribute("href", " href=\"", 2518, "\"", 2529, 1);
#nullable restore
#line 46 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2525, url, 2525, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem Thêm</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 51 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"

                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"pagination-area pt-10\">\r\n                        <nav aria-label=\"Page navigation example\">\r\n                            <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 59 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
                                 if (PageCurrent > 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3195, "\"", 3237, 2);
            WriteAttributeValue("", 3202, "/blogs.html?page=", 3202, 17, true);
#nullable restore
#line 62 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3219, PageCurrent - 1, 3219, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                            <span class=\"fa fa-chevron-left\"></span>\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 66 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""page-item"">
                                        <a class=""page-link"" href=""/blogs.html"" aria-label=""Previous"">
                                            <span class=""fa fa-chevron-left""></span>
                                        </a>
                                    </li>
");
#nullable restore
#line 74 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4003, "\"", 4039, 2);
            WriteAttributeValue("", 4010, "/blogs.html?page=", 4010, 17, true);
#nullable restore
#line 76 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4027, PageCurrent, 4027, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
                                                                                                                  Write(PageCurrent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4138, "\"", 4171, 2);
            WriteAttributeValue("", 4145, "/blogs.html?page=", 4145, 17, true);
#nullable restore
#line 77 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4162, PageNext, 4162, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
                                                                                                        Write(PageNext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4305, "\"", 4338, 2);
            WriteAttributeValue("", 4312, "/blogs.html?page=", 4312, 17, true);
#nullable restore
#line 79 "E:\ShopGiay\ShopGiay\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4329, PageNext, 4329, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Next"">
                                        <span class=""fa fa-chevron-right""></span>
                                    </a>
                                </li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<ShopGiay.Models.TinDang>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
