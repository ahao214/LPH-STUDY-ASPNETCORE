#pragma checksum "F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\T6_1\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7b583bf6bafa7596265bc9d591f83a9d561cb46d99abf49eb2d77476fee90071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\T6_1\Views\_ViewImports.cshtml"
using T6_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\T6_1\Views\_ViewImports.cshtml"
using T6_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7b583bf6bafa7596265bc9d591f83a9d561cb46d99abf49eb2d77476fee90071", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"39661ba310e3c71270612017fee8e1bc2d35656c8307f4fcc3c91eb217a85058", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\T6_1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    <a href=\"/Home/ReadData\">获取redis数据</a>\r\n");
#nullable restore
#line 7 "F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\T6_1\Views\Home\Index.cshtml"
     if(ViewBag.TimeNow !=null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>");
#nullable restore
#line 9 "F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\T6_1\Views\Home\Index.cshtml"
         Write(ViewBag.TimeNow);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 10 "F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\T6_1\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\T6_1\Views\Home\Index.cshtml"
     if(ViewBag.p !=null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>\r\n            ");
#nullable restore
#line 15 "F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\T6_1\Views\Home\Index.cshtml"
       Write(ViewBag.p.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\T6_1\Views\Home\Index.cshtml"
                     Write(ViewBag.p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\T6_1\Views\Home\Index.cshtml"
                                            Write(ViewBag.p.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>    \r\n");
#nullable restore
#line 17 "F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\T6_1\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>\r\n    <a class=\"btn btn-primary\" href=\"/Home/DelData\" >删除redis数据</a>\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
