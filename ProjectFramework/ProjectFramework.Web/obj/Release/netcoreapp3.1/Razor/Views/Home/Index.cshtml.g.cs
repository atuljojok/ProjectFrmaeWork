#pragma checksum "E:\C++ Sample\ProjectFramework\ProjectFramework.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d507461d4d19f7fef88729c7defeb1eb4d7dd83"
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
#line 1 "E:\C++ Sample\ProjectFramework\ProjectFramework.Web\Views\_ViewImports.cshtml"
using ProjectFramework.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C++ Sample\ProjectFramework\ProjectFramework.Web\Views\_ViewImports.cshtml"
using ProjectFramework.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d507461d4d19f7fef88729c7defeb1eb4d7dd83", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b2ea9151447642f642864ae99f3df850a624e2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\C++ Sample\ProjectFramework\ProjectFramework.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1>");
#nullable restore
#line 7 "E:\C++ Sample\ProjectFramework\ProjectFramework.Web\Views\Home\Index.cshtml"
   Write(Model.MainHeading);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n    <p class=\"lead\">");
#nullable restore
#line 8 "E:\C++ Sample\ProjectFramework\ProjectFramework.Web\Views\Home\Index.cshtml"
               Write(Model.MainDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    <p><a href=""http://www.ktsinfotech.com"" class=""btn btn-primary btn-lg"">Learn more &raquo;</a></p>
</div>

<div class=""row"">
    <div class=""col-md-4"">
        <h2>Getting started</h2>
        <p>
            This <span style=""color: #000099""><strong>ASP.NET Web Project Framework</strong></span> lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
        </p>
        <p>
            <a class=""btn btn-dark"" href=""http://training.ktsinfotech.com"">Learn more &raquo;</a>
        </p>
    </div>
    <div class=""col-md-4"">
        <h2>Database Support</h2>
        <p>
            Database Support is Given For OLD DB Database as well as ODBC Based Databases .
            Default Database script in App_Data Folder for MS Access and MySQL. <span style=""color: #0000FF"">Default Connection String in Web.config is for");
            WriteLiteral(@" MS Access.The site default user name / password is admin / admin </span>
        </p>
        <p>
            <a class=""btn btn-dark"" href=""http://training.ktsinfotech.com"">Learn more &raquo;</a>
        </p>
    </div>
    <div class=""col-md-4"">
        <h2>Web Hosting</h2>
        <p>
            You can easily find a web hosting company that offers the right mix of features and price for your applications. <span style=""color: #0000CC"">Some of the Hosting providers for which this Site Framework tested includes Shared Hosting Servers like Godaddy , Hostgator and Dedicated Servers like Amazon Lightsail etc. </span>
        </p>
        <p>
            <a class=""btn btn-dark"" href=""http://training.ktsinfotech.com"">Learn more &raquo;</a>
        </p>
    </div>
</div>

<div class=""text-center"">
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591