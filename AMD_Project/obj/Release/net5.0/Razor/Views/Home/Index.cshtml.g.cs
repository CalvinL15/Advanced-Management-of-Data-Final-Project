#pragma checksum "/Users/calvinliu15/Desktop/TU Chemnitz/Semester I/AMD/AMD_Project/AMD_Project/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46421c5d5c548399ed9ea32a2be89469cb4dd7b6"
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
#line 1 "/Users/calvinliu15/Desktop/TU Chemnitz/Semester I/AMD/AMD_Project/AMD_Project/Views/_ViewImports.cshtml"
using AMD_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/calvinliu15/Desktop/TU Chemnitz/Semester I/AMD/AMD_Project/AMD_Project/Views/_ViewImports.cshtml"
using AMD_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46421c5d5c548399ed9ea32a2be89469cb4dd7b6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ef276933e5d2314c658c17956688671d421d756", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/calvinliu15/Desktop/TU Chemnitz/Semester I/AMD/AMD_Project/AMD_Project/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-left"">
    <h4 class=""text-justify my-2"">Welcome! This web application is created as one of the components for the final project
    of the Advanced Management of Data WS2021/2022 course, to serve as the UI that provides clear visualisation and way of
    interaction between user and the PostgreSQL database.
    </h4>
    <hr />
    <p class=""text-justify"">This project is developed with <a href=""https://docs.microsoft.com/en-us/aspnet/core/"" target=""_blank"">ASP.NET Core </a>(.AspNetCore 5.0.0) using the MVC Web Application Template in Visual Studio,
    and uses these following dependencies/plugins/tech-stacks/etc: </p>
    <ul>
        <li><b>Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation (5.0.13)</b> as this webapp uses Razor templating engine</li>
        <li><a href=""https://www.npgsql.org/"" target=""_blank""><b>Npgsql (6.0.3)</b></a> to access the PostgreSQL database server</li>
        <li><b>System.Configuration.ConfigurationManager (6.0.0)</b> to handles the configuration for the da");
            WriteLiteral(@"tabase connection</li>
        <li><a href=""https://getbootstrap.com/"" target=""_blank""><b>Bootstrap v4.3.1</b></a> for styling purposes</li>
        <li><a href=""https://jquery.com"" target=""_blank""><b>jQuery v3.5.1</b></a> as the javascript framework</li>
        <li><b><a href=""https://datatables.net/"" target=""_blank"">DataTables v1.10.2</a></b> for multi-features table</li>
        <li><b><a href=""https://github.com/brianvoe/slim-select"" target=""_blank"">Slim Select 1.27.1 </a></b> for better multi-select dropdown</li>
    </ul>
    <p>For more details regarding this project, please check out the term paper!</p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591