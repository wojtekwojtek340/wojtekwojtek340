#pragma checksum "C:\Users\Dell\source\repos\WebApplication3\WebApplication3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5bddd05690eb74cef67f5c0331b306e6a6c8110"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Dell\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#line 2 "C:\Users\Dell\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5bddd05690eb74cef67f5c0331b306e6a6c8110", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(7, 53, false);
#line 2 "C:\Users\Dell\source\repos\WebApplication3\WebApplication3\Views\Home\Index.cshtml"
Write(Html.ActionLink("Przejdz", "IntrestingLinks", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(60, 25, true);
            WriteLiteral("</h2>\r\n\r\n\r\n<hr />\r\n\r\n<h3>");
            EndContext();
            BeginContext(86, 66, false);
#line 7 "C:\Users\Dell\source\repos\WebApplication3\WebApplication3\Views\Home\Index.cshtml"
Write(Html.ActionLink("Pokaż wszystkie samochody", "GetallCars", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(152, 23, true);
            WriteLiteral("</h3>\r\n\r\n<hr />\r\n\r\n<h3>");
            EndContext();
            BeginContext(176, 64, false);
#line 11 "C:\Users\Dell\source\repos\WebApplication3\WebApplication3\Views\Home\Index.cshtml"
Write(Html.ActionLink("Pokaz liste modeli", "GetListOfModels", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(240, 23, true);
            WriteLiteral("</h3>\r\n\r\n<hr />\r\n\r\n<h3>");
            EndContext();
            BeginContext(264, 62, false);
#line 15 "C:\Users\Dell\source\repos\WebApplication3\WebApplication3\Views\Home\Index.cshtml"
Write(Html.ActionLink("Formularz kontaktowy", "ContactForm", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(326, 5, true);
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
