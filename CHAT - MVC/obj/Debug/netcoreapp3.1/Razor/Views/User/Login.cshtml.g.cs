#pragma checksum "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "458af6c287dbb6e121267321066984b1c3a15b4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458af6c287dbb6e121267321066984b1c3a15b4a", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"009d62d744f754d2610d8f32136cc67eed883a70", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<br />\r\n<center>\r\n    <h1>LOGIN</h1>\r\n    <div class=\"col-md-4\">\r\n        <section>\r\n");
#nullable restore
#line 9 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\Login.cshtml"
             using (Html.BeginForm("Login", "User", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "458af6c287dbb6e121267321066984b1c3a15b4a3694", async() => {
                WriteLiteral("\r\n                <hr />\r\n                <center>\r\n                    <p><span class=\"text-danger\">");
#nullable restore
#line 14 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\Login.cshtml"
                                            Write(ViewBag.Result);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></p>
                </center>
                <div class=""text-danger validation-summary-valid"" data-valmsg-summary=""true"">
                    <ul>
                        <li style=""display:none""></li>
                    </ul>
                </div>
                <div class=""form-group"">
                    <label for=""Input_Email"">Usuario</label>
                    <input class=""form-control"" type=""text"" data-val=""true"" data-val-user=""The Email field is not a valid e-mail address."" data-val-required=""The Email field is required."" id=""Input_Email"" name=""User""");
                BeginWriteAttribute("value", " value=\"", 958, "\"", 966, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    <span class=""text-danger field-validation-valid"" data-valmsg-for=""Input.Email"" data-valmsg-replace=""true""></span>
                </div>
                <div class=""form-group"">
                    <label for=""Input_Password"">Contraseña</label>
                    <input class=""form-control"" type=""password"" data-val=""true"" data-val-required=""The Password field is required."" id=""Input_Password"" name=""Password"" />
                    <span class=""text-danger field-validation-valid"" data-valmsg-for=""Input.Password"" data-valmsg-replace=""true""></span>
                </div>
                <p class=""list-group-item-text text-left text-muted"">
                    <small>
                        ¿No posee una cuenta?
                        <br />
                        ");
#nullable restore
#line 35 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\Login.cshtml"
                   Write(Html.ActionLink("Crea una nueva cuenta aquí", "Register", "User", null, new { style = "text-decoration:none; color:gray" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </small>\r\n                </p>\r\n                <div class=\"form-group\">\r\n                    <button id=\"login-submit\" type=\"submit\" class=\"btn btn-primary\">ENTRAR</button>\r\n                </div>\r\n            ");
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
#line 42 "C:\Users\kevin\Desktop\Proyec Ngrok\PROYECTO---ED2\CHAT - MVC\Views\User\Login.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </div>\r\n</center>");
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
