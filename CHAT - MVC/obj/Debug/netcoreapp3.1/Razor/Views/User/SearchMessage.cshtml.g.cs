#pragma checksum "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\SearchMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "979f211fa6a4b64af75e1e0c42467c510186dbac"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"979f211fa6a4b64af75e1e0c42467c510186dbac", @"/Views/User/SearchMessage.cshtml")]
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
            WriteLiteral(@"
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
        <li class=""breadcrumb-item""><a href=""#"">Library</a></li>
        <li class=""breadcrumb-item active"">Data</li>
    </ol>

<h1>BÚSQUEDA</h1>
<hr />
<div class=""col-md-4"">
");
#nullable restore
#line 12 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\SearchMessage.cshtml"
     using (Html.BeginForm("SearchMessage", "User", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "979f211fa6a4b64af75e1e0c42467c510186dbac3867", async() => {
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
#line 22 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\SearchMessage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
#nullable restore
#line 26 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\SearchMessage.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n<blockquote class=\"blockquote\">\r\n    <p class=\"mb-0 justify-content-around\"><b>");
#nullable restore
#line 30 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\SearchMessage.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n    <footer class=\"blockquote-footer\">");
#nullable restore
#line 31 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\SearchMessage.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Transmitter));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br><cite title=\"Source Title\">");
#nullable restore
#line 31 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\SearchMessage.cshtml"
                                                                                                                Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</cite></footer>\r\n    <footer class=\"blockquote-footer\">");
#nullable restore
#line 32 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\SearchMessage.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</footer>\r\n</blockquote>\r\n");
#nullable restore
#line 34 "C:\Users\José De León\Desktop\NEW ED 2\CHAT - MVC\Views\User\SearchMessage.cshtml"
}

#line default
#line hidden
#nullable disable
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