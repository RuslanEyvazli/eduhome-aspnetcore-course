#pragma checksum "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Shared\SearchBlogPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46e02a5cac37de9261fdca868063905389b8cdaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SearchBlogPartial), @"mvc.1.0.view", @"/Views/Shared/SearchBlogPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/SearchBlogPartial.cshtml", typeof(AspNetCore.Views_Shared_SearchBlogPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46e02a5cac37de9261fdca868063905389b8cdaa", @"/Views/Shared/SearchBlogPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d711477a0a799f53f6047043ae49bec4a4f13ea0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SearchBlogPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Shared\SearchBlogPartial.cshtml"
 foreach (Blog blog in Model)
{

#line default
#line hidden
            BeginContext(51, 41, true);
            WriteLiteral("    <li  style=\"display:flex\">\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 92, "\"", 123, 2);
            WriteAttributeValue("", 99, "/Teacher/Detail/", 99, 16, true);
#line 6 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Shared\SearchBlogPartial.cshtml"
WriteAttributeValue("", 115, blog.Id, 115, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(124, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(126, 12, false);
#line 6 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Shared\SearchBlogPartial.cshtml"
                                      Write(blog.Explain);

#line default
#line hidden
            EndContext();
            BeginContext(138, 15, true);
            WriteLiteral("</a>\n    </li>\n");
            EndContext();
#line 8 "C:\Users\rusey\Downloads\p507-asp-net-core-project-mubucimbom-master\BackendProjectFinal\BackendProject\Views\Shared\SearchBlogPartial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
