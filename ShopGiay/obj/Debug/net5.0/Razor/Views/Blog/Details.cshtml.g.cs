#pragma checksum "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e631f7cb0d22f2eeb271ac14ad00632cdca36d3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e631f7cb0d22f2eeb271ac14ad00632cdca36d3c", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd452c5f67e48a959597e4e8a38cee4ceb59688", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopGiay.Models.TinDang>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";
    string url = $"/tin-tuc/{Model.Alias}-{Model.PostId}.html";
    List<TinDang> Baivietlienquan = ViewBag.Baivietlienquan;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""~/assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h1 class=""breadcrumb-heading"">");
#nullable restore
#line 14 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
                                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <ul>\r\n                            <li> \r\n                                <a href=\"/\">Trang chủ <i class=\"pe-7s-angle-right\"></i></a>\r\n                            </li>\r\n                            <li>");
#nullable restore
#line 19 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""blog-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""blog-detail-item"">
                        <div class=""blog-img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e631f7cb0d22f2eeb271ac14ad00632cdca36d3c5249", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1327, "~/images/tindangs/", 1327, 18, true);
#nullable restore
#line 32 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 1345, Model.Thumb, 1345, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 1364, Model.Title, 1364, 12, false);

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
                        </div>
                        <div class=""blog-content text-start pb-0"">
                            <div class=""blog-meta text-dim-gray pb-3"">
                                <ul>
                                    <li class=""date""><i class=""fa fa-calendar-o me-2""></i>");
#nullable restore
#line 37 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
                                                                                     Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                            <h5 class=\"title mb-4\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1867, "\"", 1878, 1);
#nullable restore
#line 41 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
WriteAttributeValue("", 1874, url, 1874, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n                            <p class=\"short-desc mb-4 mb-7\">");
#nullable restore
#line 43 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
                                                       Write(Model.Scontents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            ");
#nullable restore
#line 44 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
                       Write(Html.Raw(Model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            
                            <div class=""feedback-area section-space-top-55"">
                                <h4 class=""heading mb-1"">Bài viết liên quan</h4>
                                <hr />
                                <div class=""widgets-area mb-9"">
                                    <div class=""widgets-item"">
                                        <div class=""swiper-container widgets-list-slider style-2 swiper-container-multirow swiper-container-initialized swiper-container-horizontal swiper-container-pointer-events"">
                                            <div class=""swiper-wrapper"" id=""swiper-wrapper-62104b1dfbb1d3188"" aria-live=""polite"" style=""width: 288px; transform: translate3d(0px, 0px, 0px);"">
");
#nullable restore
#line 53 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
                                                 if (Baivietlienquan != null && Baivietlienquan.Count() > 0)
                                                {
                                                    foreach (var item in Baivietlienquan)
                                                    {
                                                        string _url = $"/tin-tuc/{item.Alias}-{item.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                            <div class=""swiper-slide"" role=""group"" aria-label=""3 / 3"" style=""margin-top: 25px; width: 263px; margin-right: 25px;"">
                                                                    <div class=""product-list-item"">
                                                                        <div class=""product-img img-zoom-effect"">
                                                                            <a");
            BeginWriteAttribute("href", " href=\"", 3749, "\"", 3761, 1);
#nullable restore
#line 61 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
WriteAttributeValue("", 3756, _url, 3756, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e631f7cb0d22f2eeb271ac14ad00632cdca36d3c11394", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3872, "~/images/tindangs/", 3872, 18, true);
#nullable restore
#line 62 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 3890, item.Thumb, 3890, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 62 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 3908, item.Title, 3908, 11, false);

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
                                                                        <div class=""product-content"">
                                                                            <h5 class=""title mb-3"">
                                                                                <a");
            BeginWriteAttribute("href", " href=\"", 4371, "\"", 4383, 1);
#nullable restore
#line 67 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
WriteAttributeValue("", 4378, _url, 4378, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 67 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
                                                                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                                            </h5>
                                                                            <div class=""blog-meta text-manatee pb-1"">
                                                                                <ul>
                                                                                    <li class=""date"">");
#nullable restore
#line 71 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"
                                                                                                Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                                                                </ul>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
");
#nullable restore
#line 77 "E:\ShopGiay\ShopGiay\Views\Blog\Details.cshtml"

                                                    }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopGiay.Models.TinDang> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
