#pragma checksum "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17b33eb71fd459f9980cbc8acd75488c5b6a10e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_QueryChat), @"mvc.1.0.view", @"/Views/User/QueryChat.cshtml")]
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
#line 1 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\_ViewImports.cshtml"
using CHAT___MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\_ViewImports.cshtml"
using CHAT___MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17b33eb71fd459f9980cbc8acd75488c5b6a10e9", @"/Views/User/QueryChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"009d62d744f754d2610d8f32136cc67eed883a70", @"/Views/_ViewImports.cshtml")]
    public class Views_User_QueryChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MessageModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("user", new global::Microsoft.AspNetCore.Html.HtmlString("ViewBag.Second"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">");
#nullable restore
#line 4 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                               Write(Html.ActionLink("PRINCIPAL", "Index", "User"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"breadcrumb-item active\">CHAT</li>\r\n    </ol>\r\n\r\n\r\n\r\n<h1>CHAT</h1>\r\n<p class=\"btn btn-secondary btn-sm float-right\">");
#nullable restore
#line 11 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                           Write(Html.ActionLink("ARCHIVOS", "DownloadFiles", new { user = ViewBag.Second }, new { style = "text-decoration:none; color:white" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p class=\"btn btn-primary btn-sm float-right\">");
#nullable restore
#line 12 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                         Write(Html.ActionLink("ACTUALIZAR", "QueryChat", new { user = ViewBag.Second }, new { style = "text-decoration:none; color:white" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h6>");
#nullable restore
#line 13 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
Write(ViewBag.Logged);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 13 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                 Write(ViewBag.Second);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<h2 class=\"text-success\"> ");
#nullable restore
#line 14 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                     Write(ViewBag.ConfirmationFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<hr />\r\n\r\n");
#nullable restore
#line 17 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
 if (ViewBag.Result != null || ViewBag.Result2 != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-dismissible alert-warning\">\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
     if (ViewBag.Result != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            <small class=\"mb-auto\">\r\n                <strong>");
#nullable restore
#line 26 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                   Write(ViewBag.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </small>\r\n        </p>\r\n");
#nullable restore
#line 29 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
     if (ViewBag.Result2 != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"mb-auto\">\r\n            <small>\r\n                <strong>");
#nullable restore
#line 36 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                   Write(ViewBag.Result2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </small>\r\n        </p>\r\n");
#nullable restore
#line 39 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 42 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"col-md-12\">\r\n");
#nullable restore
#line 47 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
         if (item.Transmitter == ViewBag.Logged)
        {
            if (item.Type == 2)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                 using (Html.BeginForm("Download", "User", new { user = ViewBag.Second }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""list-group"">
                                <div class=""list-group-item list-group-item-action flex-column align-items-start"">
                                    <div class=""d-flex w-100 justify-content-between"">
                                        <h5 class=""mb-1""></h5>
                                        <small class=""text-muted"">");
#nullable restore
#line 61 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </div>\r\n                                    <p class=\"mb-auto\"><b>");
#nullable restore
#line 63 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                                    <small class=\"text-muted\">");
#nullable restore
#line 64 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.Transmitter));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                    <p class=""mb-0 justify-content-around""> 
                                    <b><input type=""submit"" class=""btn btn-primary btn-sm float-right"" value=""Descargar"" /></b>
                                        <input type=""text"" id=""val2"" class=""border-0 invisible"" name=""Register""");
            BeginWriteAttribute("value", " value=\"", 2704, "\"", 2761, 1);
#nullable restore
#line 67 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
WriteAttributeValue(" ", 2712, Html.DisplayFor(modelItem => item.RegisterName), 2713, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly>\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 73 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""list-group"">
                            <div class=""list-group-item list-group-item-action flex-column align-items-start"">
                                <div class=""d-flex w-100 justify-content-between"">
                                    <h5 class=""mb-1""></h5>
                                    <small class=""text-muted"">");
#nullable restore
#line 83 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                                <p class=\"mb-auto\"><b>");
#nullable restore
#line 85 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                                <small class=\"text-muted\">");
#nullable restore
#line 86 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Transmitter));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 91 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
            }
        }
        else
        {
            if (item.Type == 2)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                 using (Html.BeginForm("Download", "User", new { user = ViewBag.Second }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                        </div>
                        <div class=""col-md-6"">
                            <div class=""list-group"">
                                <div class=""list-group-item list-group-item-action flex-column align-items-end"">
                                    <div class=""d-flex w-100 justify-content-between"">
                                        <h5 class=""mb-1""></h5>
                                        <small class=""text-muted"">");
#nullable restore
#line 107 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </div>\r\n                                    <p class=\"mb-auto float-right\"><b>");
#nullable restore
#line 109 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                                    <br />\r\n                                    <small class=\"text-muted float-right\">");
#nullable restore
#line 111 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.Transmitter));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                    <p class=""mb-0 justify-content-around""> 
                                    <b><input type=""submit"" class=""btn btn-primary btn-sm float-left"" value=""Descargar"" /></b>
                                    <input type=""text"" id=""val2"" class=""border-0 invisible"" name=""Register""");
            BeginWriteAttribute("value", " value=\"", 5366, "\"", 5423, 1);
#nullable restore
#line 114 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
WriteAttributeValue(" ", 5374, Html.DisplayFor(modelItem => item.RegisterName), 5375, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly>\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>                    \r\n");
#nullable restore
#line 120 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-md-6"">
                    </div>
                    <div class=""col-md-6"">
                        <div class=""list-group"">
                            <div class=""list-group-item list-group-item-action flex-column align-items-end"">
                                <div class=""d-flex w-100 justify-content-between"">
                                    <h5 class=""mb-1""></h5>
                                    <small class=""text-muted"">");
#nullable restore
#line 132 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                                <p class=\"mb-auto float-right\"><b>");
#nullable restore
#line 134 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                                <br />\r\n                                <small class=\"text-muted float-right\">");
#nullable restore
#line 136 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.Transmitter));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 141 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n");
#nullable restore
#line 146 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
     using (Html.BeginForm("QueryChat", "User", new { user = ViewBag.Second }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17b33eb71fd459f9980cbc8acd75488c5b6a10e922286", async() => {
                WriteLiteral(@"
            <fieldset>
                <div class=""form-group"">
                    <label for=""exampleTextarea"">Escribe un mensaje</label>
                    <textarea class=""form-control"" id=""exampleTextarea"" rows=""3"" name=""Message""></textarea>
                </div>

                <button type=""submit"" class=""btn btn-success btn-lg btn-block"">ENVIAR</button>
            </fieldset>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 158 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17b33eb71fd459f9980cbc8acd75488c5b6a10e924268", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""exampleInputFile""><b>ADJUNTAR ARCHIVO</b></label>
            <br />
            <input type=""submit"" class=""btn btn-primary float-right"" value=""ENVIAR ARCHIVO"" />
            <input type=""file"" name=""file"" /> <input type=""text"" id=""User"" class=""border-0 invisible"" name=""user""");
                BeginWriteAttribute("value", " value=\"", 7782, "\"", 7805, 1);
#nullable restore
#line 166 "C:\Users\José De León\Desktop\ED2 THURSDAY FINAL\PROYECTO---ED2\CHAT - MVC\Views\User\QueryChat.cshtml"
WriteAttributeValue("", 7790, ViewBag.Second, 7790, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
