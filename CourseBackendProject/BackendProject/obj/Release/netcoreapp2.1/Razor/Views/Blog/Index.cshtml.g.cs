#pragma checksum "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b7c9e97ff7d962b7ff255ee449e9dfcc34362f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Index.cshtml", typeof(AspNetCore.Views_Blog_Index))]
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
#line 1 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\_ViewImports.cshtml"
using BackendProject.Models;

#line default
#line hidden
#line 2 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\_ViewImports.cshtml"
using BackendProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b7c9e97ff7d962b7ff255ee449e9dfcc34362f2", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d711477a0a799f53f6047043ae49bec4a4f13ea0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(63, 629, true);
            WriteLiteral(@"

<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>blog</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Blog Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
");
            EndContext();
#line 28 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
             foreach (Blog blog in Model)
            {

#line default
#line hidden
            BeginContext(748, 185, true);
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 col-xs-12\">\n                    <div class=\"single-blog mb-60\">\n                        <div class=\"blog-img\">\n                            ");
            EndContext();
            BeginContext(933, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b7c9e97ff7d962b7ff255ee449e9dfcc34362f28341", async() => {
                BeginContext(1002, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b7c9e97ff7d962b7ff255ee449e9dfcc34362f28605", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1012, "~/img/blog/", 1012, 11, true);
#line 33 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1023, blog.Image, 1023, 11, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                                                           WriteLiteral(blog.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1051, 319, true);
            WriteLiteral(@"
                            <div class=""blog-hover"">
                                <i class=""fa fa-link""></i>
                            </div>
                        </div>
                        <div class=""blog-content"">
                            <div class=""blog-top"">
                                <p>By ");
            EndContext();
            BeginContext(1371, 15, false);
#line 40 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                 Write(blog.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(1386, 5, true);
            WriteLiteral("  /  ");
            EndContext();
            BeginContext(1392, 9, false);
#line 40 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                                      Write(blog.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1401, 169, true);
            WriteLiteral("  /  <i class=\"fa fa-comments-o\"></i> 4</p>\n                            </div>\n                            <div class=\"blog-bottom\">\n                                <h2>");
            EndContext();
            BeginContext(1570, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b7c9e97ff7d962b7ff255ee449e9dfcc34362f213848", async() => {
                BeginContext(1640, 12, false);
#line 43 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                                                                                    Write(blog.Explain);

#line default
#line hidden
                EndContext();
                BeginContext(1652, 1, true);
                WriteLiteral(" ");
                EndContext();
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                                                                   WriteLiteral(blog.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1657, 38, true);
            WriteLiteral("</h2>\n                                ");
            EndContext();
            BeginContext(1695, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b7c9e97ff7d962b7ff255ee449e9dfcc34362f216878", async() => {
                BeginContext(1764, 9, true);
                WriteLiteral("read more");
                EndContext();
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                                                               WriteLiteral(blog.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1777, 117, true);
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 49 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(1909, 144, true);
            WriteLiteral("            <div class=\"row\">\n                <div class=\"col-xs-12\">\n                    <div class=\"pagination\">\n                        <ul>\n");
            EndContext();
#line 55 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                             for (int i = 1; i <= ViewBag.PageCount; i++)
                            {
                                if (ViewBag.Page == null)
                                {

                                    if (i == 1)
                                    {

#line default
#line hidden
            BeginContext(2336, 92, true);
            WriteLiteral("                                        <li  style=\"pointer-events:none\"><a class=\"disabled\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2428, "\"", 2454, 2);
            WriteAttributeValue("", 2435, "/Blog/Index?page=", 2435, 17, true);
#line 62 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2452, i, 2452, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2455, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2457, 1, false);
#line 62 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                                                                                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2458, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 63 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2585, 46, true);
            WriteLiteral("                                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2631, "\"", 2657, 2);
            WriteAttributeValue("", 2638, "/Blog/Index?page=", 2638, 17, true);
#line 66 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2655, i, 2655, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2658, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2660, 1, false);
#line 66 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                                                     Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2661, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 67 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                    }
                                }
                                else
                                {
                                    if (i == ViewBag.Page)
                                    {

#line default
#line hidden
            BeginContext(2911, 91, true);
            WriteLiteral("                                        <li style=\"pointer-events:none\"><a class=\"disabled\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3002, "\"", 3028, 2);
            WriteAttributeValue("", 3009, "/Blog/Index?page=", 3009, 17, true);
#line 73 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3026, i, 3026, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3029, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3031, 1, false);
#line 73 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                                                                                                  Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3032, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 74 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3159, 46, true);
            WriteLiteral("                                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3205, "\"", 3231, 2);
            WriteAttributeValue("", 3212, "/Blog/Index?page=", 3212, 17, true);
#line 77 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3229, i, 3229, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3232, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3234, 1, false);
#line 77 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                                                     Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3235, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 78 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Blog\Index.cshtml"
                                    }
                                }

                            }

#line default
#line hidden
            BeginContext(3348, 642, true);
            WriteLiteral(@"

                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
        
</div>
<!-- Blog End -->
<!-- Subscribe Start -->
<div class=""subscribe-area pt-60 pb-70"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-2"">
                <div class=""subscribe-content section-title text-center"">
                    <h2>subscribe our newsletter</h2>
                    <p>I must explain to you how all this mistaken idea </p>
                </div>
                <div class=""newsletter-form mc_embed_signup"">
                    ");
            EndContext();
            BeginContext(3990, 969, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b7c9e97ff7d962b7ff255ee449e9dfcc34362f227101", async() => {
                BeginContext(4227, 122, true);
                WriteLiteral("\n                        <div id=\"mc_embed_signup_scroll\" class=\"mc-form\">\n                            <input type=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4349, "\"", 4357, 0);
                EndWriteAttribute();
                BeginContext(4358, 380, true);
                WriteLiteral(@" name=""EMAIL"" class=""email"" id=""mce-EMAIL"" placeholder=""Enter your e-mail address"" required>
                            <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                            <div class=""mc-news"" aria-hidden=""true""><input type=""text"" name=""b_6bbb9b6f5827bd842d9640c82_05d85f18ef"" tabindex=""-1""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4738, "\"", 4746, 0);
                EndWriteAttribute();
                BeginContext(4747, 205, true);
                WriteLiteral("></div>\n                            <button id=\"mc-embedded-subscribe\" class=\"default-btn\" type=\"submit\" name=\"subscribe\"><span>subscribe</span></button>\n                        </div>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4959, 557, true);
            WriteLiteral(@"
                    <!-- mailchimp-alerts Start -->
                    <div class=""mailchimp-alerts"">
                        <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                        <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                        <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                    </div>
                    <!-- mailchimp-alerts end -->
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Subscribe End -->
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
