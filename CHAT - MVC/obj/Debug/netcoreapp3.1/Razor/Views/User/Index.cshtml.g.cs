#pragma checksum "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43c6b9d6bf751e0966ecce00fa6031b1d352df27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\_ViewImports.cshtml"
using CHAT___MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\_ViewImports.cshtml"
using CHAT___MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43c6b9d6bf751e0966ecce00fa6031b1d352df27", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"009d62d744f754d2610d8f32136cc67eed883a70", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>BIENVENIDO</h1>\r\n<h6>");
#nullable restore
#line 4 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\Index.cshtml"
Write(ViewBag.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n<hr />\r\n\r\n<br />\r\n<a class=\"btn btn-secondary btn-lg\"");
            BeginWriteAttribute("href", " href=\'", 130, "\'", 172, 1);
#nullable restore
#line 9 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\Index.cshtml"
WriteAttributeValue("", 137, Url.Action("SearchMessage","User"), 137, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">BÚSCAR MENSAJE</a>\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-3"">
            <div class=""list-group"">
                <div class=""list-group-item"">
                    <center>
                        <img src=""https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png"" height=""150"">
                        <hr />
                        <h4 class=""list-group-item-heading""><i>");
#nullable restore
#line 23 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\Index.cshtml"
                                                          Write(Html.DisplayFor(model => item));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></h4>\r\n                        <p class=\"btn btn-primary\">");
#nullable restore
#line 24 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\Index.cshtml"
                                              Write(Html.ActionLink("ENVIAR MENSAJE", "QueryChat", new { user = item }, new { style = "text-decoration:none; color:white" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </center>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <br />\r\n");
#nullable restore
#line 30 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
