#pragma checksum "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\SearchMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acab8e3f97920bf7487107d5961ce8e2b1da5b3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_SearchMessage), @"mvc.1.0.view", @"/Views/User/SearchMessage.cshtml")]
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
#line 1 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\_ViewImports.cshtml"
using CHAT___MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\_ViewImports.cshtml"
using CHAT___MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acab8e3f97920bf7487107d5961ce8e2b1da5b3a", @"/Views/User/SearchMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"009d62d744f754d2610d8f32136cc67eed883a70", @"/Views/_ViewImports.cshtml")]
    public class Views_User_SearchMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MessageModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item\">");
#nullable restore
#line 4 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\SearchMessage.cshtml"
                           Write(Html.ActionLink("PRINCIPAL", "Index", "User"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li class=\"breadcrumb-item active\">BUSCAR MENSAJE</li>\r\n</ol>\r\n\r\n<h1>BÚSQUEDA</h1>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 12 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\SearchMessage.cshtml"
         using (Html.BeginForm("SearchMessage", "User", FormMethod.Post, new { enctype = "multipart/form-data" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acab8e3f97920bf7487107d5961ce8e2b1da5b3a4160", async() => {
                WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""exampleInputEmail1"">Búsqueda de mensajes</label>
                    <input type=""text"" class=""form-control"" name=""Word"" placeholder=""Ingrese la palabra clave"">
                    <small id=""emailHelp"" class=""form-text text-muted"">Se obtendrán todos los mensajes en los que el usuario haya podido visualizar la palabra clave</small>
                </div>
                <button type=""submit"" class=""btn btn-primary"">BUSCAR</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\SearchMessage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <br />\r\n    <br />\r\n\r\n    <div class=\"col-md-8\">\r\n        <strong>");
#nullable restore
#line 28 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\SearchMessage.cshtml"
           Write(ViewBag.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 29 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\SearchMessage.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""list-group"">
                <div class=""list-group-item list-group-item-action flex-column align-items-start"">
                    <div class=""d-flex w-100 justify-content-between"">
                        <h5 class=""mb-1""></h5>
                        <small class=""text-muted"">");
#nullable restore
#line 36 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\SearchMessage.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </div>\r\n                    <p class=\"mb-auto\"><b>");
#nullable restore
#line 38 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\SearchMessage.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                    <small class=\"text-muted\">");
#nullable restore
#line 39 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\SearchMessage.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.Transmitter));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    <br />\r\n                    <small class=\"text-muted\">");
#nullable restore
#line 41 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\SearchMessage.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 44 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\SearchMessage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MessageModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
