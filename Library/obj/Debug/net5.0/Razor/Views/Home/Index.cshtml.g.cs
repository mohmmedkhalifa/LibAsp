#pragma checksum "C:\Users\Mohammed\Source\Repos\LibAsp\Library\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "382aa00180dcaf6aa1ee9d60b01bcaa70fa7ed0b"
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
#line 1 "C:\Users\Mohammed\Source\Repos\LibAsp\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohammed\Source\Repos\LibAsp\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"382aa00180dcaf6aa1ee9d60b01bcaa70fa7ed0b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Mohammed\Source\Repos\LibAsp\Library\Views\Home\Index.cshtml"
   
    var book = ViewData["book"] as BookModel;
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("breadcrumb", async() => {
                WriteLiteral(@"
    <nav aria-label=""breadcrumb"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Page 1</a></li>
            <li class=""breadcrumb-item active""><a href=""#"">Page 2</a></li>
        </ol>
    </nav>
");
            }
            );
            WriteLiteral("\r\n<section class=\"jumbotron text-center\">\r\n    <div class=\"container\">\r\n        <h1>Welcome To Online Library ");
#nullable restore
#line 18 "C:\Users\Mohammed\Source\Repos\LibAsp\Library\Views\Home\Index.cshtml"
                                 Write(ViewData["MyData"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
     
        <p class=""lead text-muted"">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
        </p>
        <p>
            <a href=""#"" class=""btn btn-primary my-2"">Search</a>
        </p>
    </div>
</section>


<div class=""py-5 bg-light"">
    <div class=""container"">
        <h3 class=""h3"">Top Books</h3>
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225 "" xmlns=""https://getuikit.com/v2/docs/images/placeholder_600x400.svg""></svg>
 ");
            WriteLiteral(@"                   <div class=""card-body"">
                        <p class=""card-text"">
                            Here Will Display the short description for every book
                        </p>
                        <div class=""d-flex justify-content-between align-items-center"">
                            <div class=""btn-group"">
                                <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Details</a>
                            </div>
                            <small class=""text-muted"">Author Nane</small>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225 "" xmlns=""https://getuikit.com/v2/docs/images/placeholder_600x400.svg""></svg>
                    <div class=""card-body"">
                        <p class=""card-text"">
            ");
            WriteLiteral(@"                Here Will Display the short description for every book
                        </p>
                        <div class=""d-flex justify-content-between align-items-center"">
                            <div class=""btn-group"">
                                <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Details</a>
                            </div>
                            <small class=""text-muted"">Author Nane</small>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225 "" xmlns=""https://getuikit.com/v2/docs/images/placeholder_600x400.svg""></svg>
                    <div class=""card-body"">
                        <p class=""card-text"">
                            Here Will Display the short description for every book
                        </p>
 ");
            WriteLiteral(@"                       <div class=""d-flex justify-content-between align-items-center"">
                            <div class=""btn-group"">
                                <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Details</a>
                            </div>
                            <small class=""text-muted"">Author Nane</small>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n");
                WriteLiteral("        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
