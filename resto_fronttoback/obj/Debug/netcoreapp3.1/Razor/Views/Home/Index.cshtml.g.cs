#pragma checksum "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d3ff9b763660d671e9e67a3b2dbebc422473006"
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
#line 1 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\_ViewImports.cshtml"
using resto_fronttoback.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\_ViewImports.cshtml"
using resto_fronttoback.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d3ff9b763660d671e9e67a3b2dbebc422473006", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b4c2e9dbad9ad7be9e0353eae48b5fa35fe9a0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/steak.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/salmon-zucchini.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- main start -->
<main>
    <!-- hero start -->
    <section id=""hero"">
        <div class=""container"">
            <div class=""row row-cols-2 row-cols-md-2 align-items-center"">
                <div class=""col"">
                    <h1>We Love <br> Delicious Foods!</h1>
                    <div class=""hero-btns"">
                        <a href=""#"" class=""btn hero-btn"">Explore Menu</a>
                        <a href=""#"" class=""film-btn""><i class=""fa-solid fa-film""></i> Play Video</a>
                    </div>
                    <div class=""hero-services"">
                        <div class=""row row-cols-1 row-cols-sm-3"">
                            <div class=""col service"">
                                <i class=""fa-solid fa-rocket""></i>
                                <p>Fast Delivery</p>
                            </div>
                            <div class=""col service"" style=""border-left: 1px solid rgb(204, 201, 201); border-right: 1px solid rgb(204, 201, 201);"">
          ");
            WriteLiteral(@"                      <i class=""fa-solid fa-leaf""></i>
                                <p>Fresh Food</p>
                            </div>
                            <div class=""col service"">
                                <i class=""fa-regular fa-comment""></i>
                                <p>24/7 Support</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col"" style=""padding: 0 0 0 2rem;"">
                    <div id=""carouselExampleControls"" class=""carousel slide"" data-bs-ride=""carousel"">
                        <div class=""carousel-inner"">
");
#nullable restore
#line 39 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                             for (int i = 0; i < Model.Slider.Count(); i++)
                            {
                                if (i == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"carousel-item active\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d3ff9b763660d671e9e67a3b2dbebc4224730067758", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2100, "~/assets/img/", 2100, 13, true);
#nullable restore
#line 44 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2113, Model.Slider.ElementAt(i).ImageUrl, 2113, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 46 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"carousel-item\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d3ff9b763660d671e9e67a3b2dbebc4224730069896", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2451, "~/assets/img/", 2451, 13, true);
#nullable restore
#line 50 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2464, Model.Slider.ElementAt(i).ImageUrl, 2464, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 52 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleControls"" data-bs-slide=""prev"">
                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                            <span class=""visually-hidden"">Previous</span>
                        </button>
                        <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleControls"" data-bs-slide=""next"">
                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                            <span class=""visually-hidden"">Next</span>
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- hero end -->
    <!-- about start -->
    <section id=""about"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-5"">");
            WriteLiteral("\n                    <div class=\"about-img h-100\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d3ff9b763660d671e9e67a3b2dbebc42247300613056", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3755, "~/assets/img/", 3755, 13, true);
#nullable restore
#line 76 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3768, Model.About.ImageUrl, 3768, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-7\">\r\n                    <div class=\"about-content\">\r\n                        <h4>");
#nullable restore
#line 81 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                       Write(Model.About.SectionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <h1>");
#nullable restore
#line 82 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                       Write(Model.About.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p>");
#nullable restore
#line 83 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                      Write(Model.About.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div class=\"about-product-body\">\r\n");
#nullable restore
#line 85 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                             for (int i = 0; i < Model.AboutSpecialRecipes.Count(); i++)
                            {
                                if (i == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h2>");
#nullable restore
#line 89 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                   Write(Model.AboutSpecialRecipes.ElementAt(i).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 90 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row row-cols-1 row-cols-md-3 g-4\">\r\n");
#nullable restore
#line 93 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                 foreach (var item in Model.AboutSpecialRecipes)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col\">\r\n                                        <div class=\"card h-100\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d3ff9b763660d671e9e67a3b2dbebc42247300617260", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4884, "~/assets/img/", 4884, 13, true);
#nullable restore
#line 97 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4897, item.ImageUrl, 4897, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <h5>");
#nullable restore
#line 98 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 101 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </section>
    <!-- about end -->
    <!-- specialties start -->
    <section id=""specialties"">
        <div class=""container"">

            <h5 class=""text-center"" style=""color: red;"">Specialties</h5>
            <h2 class=""text-center special-title"">Special Dishes</h2>
");
#nullable restore
#line 115 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.Specialties.Count(); i += 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-6 special-content-main1\">\r\n                        <div class=\"special-content d-flex align-items-center   \">\r\n                            <span>0 ");
#nullable restore
#line 120 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                               Write(Model.Specialties.ElementAt(i).Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</span>\r\n                            <div class=\"special-line\"></div>\r\n                        </div>\r\n                        <div class=\"special-text\">\r\n                            <h3>");
#nullable restore
#line 124 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                           Write(Model.Specialties.ElementAt(i).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <h5>");
#nullable restore
#line 125 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                           Write(Model.Specialties.ElementAt(i).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>\r\n                                ");
#nullable restore
#line 127 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                           Write(Model.Specialties.ElementAt(i).Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <p class=\"price\">$");
#nullable restore
#line 129 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                         Write(Model.Specialties.ElementAt(i).Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a href=\"#\" class=\"btn btn-danger\">Book a Table</a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-6 special-image d-flex justify-content-end\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d3ff9b763660d671e9e67a3b2dbebc42247300622549", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 137 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
             for (int i = 1; i < Model.Specialties.Count(); i += 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"" style=""flex-direction: row-reverse; margin-top: 4.5rem;"">
                    <div class=""col-6 special-content-main2"">
                        <div class=""special-content d-flex align-items-center   "">
                            <span>0 ");
#nullable restore
#line 143 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                               Write(Model.Specialties.ElementAt(i).Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</span>\r\n                            <div class=\"special-line\"></div>\r\n                        </div>\r\n                        <div class=\"special-text\">\r\n                            <h3>");
#nullable restore
#line 147 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                           Write(Model.Specialties.ElementAt(i).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <h5>");
#nullable restore
#line 148 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                           Write(Model.Specialties.ElementAt(i).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>\r\n                                ");
#nullable restore
#line 150 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                           Write(Model.Specialties.ElementAt(i).Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <p class=\"price\">$");
#nullable restore
#line 152 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                         Write(Model.Specialties.ElementAt(i).Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a href=\"#\" class=\"btn btn-danger\">Book a Table</a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-6 special-image d-flex justify-content-start\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d3ff9b763660d671e9e67a3b2dbebc42247300626508", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 160 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </section>
    <!-- specialties end -->
    <!-- our menu start -->
    <section id=""our-menu"">
        <div class=""container"">
            <h4>Specialties</h4>
            <h1>Our Menu</h1>
            <div class=""menu"">
                <div class=""row row-cols-lg-3"">
");
#nullable restore
#line 173 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                     foreach (var item in Model.MenuCategory)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col\">\r\n                            <h3>");
#nullable restore
#line 176 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 177 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                             foreach (var menu in Model.Menu)
                            {
                                if (menu.MenuCategoryId == item.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"menu-card\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 8875, "\"", 8908, 2);
            WriteAttributeValue("", 8881, "./assets/img/", 8881, 13, true);
#nullable restore
#line 182 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
WriteAttributeValue("", 8894, menu.ImageUrl, 8894, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8909, "\"", 8915, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"menu-content\">\r\n                                            <h2>");
#nullable restore
#line 184 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                           Write(menu.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                            <h5>");
#nullable restore
#line 185 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                           Write(menu.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        </div>\r\n                                        <span class=\"menu-price\">$");
#nullable restore
#line 187 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                                             Write(menu.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n");
#nullable restore
#line 189 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 192 "C:\Users\heyde\OneDrive\Desktop\RestoBack\resto_fronttoback\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- our menu end -->\r\n\r\n</main>\r\n<!-- main end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
