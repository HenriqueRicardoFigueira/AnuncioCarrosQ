#pragma checksum "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dc54a638a44b09340ba4c2fdb4883c5c8addbfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anuncios_Delete), @"mvc.1.0.view", @"/Views/Anuncios/Delete.cshtml")]
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
#line 1 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\_ViewImports.cshtml"
using GerenciadorDeAnuncio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\_ViewImports.cshtml"
using GerenciadorDeAnuncio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dc54a638a44b09340ba4c2fdb4883c5c8addbfb", @"/Views/Anuncios/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78ee2e6e20a0a7ef64b510f2c9bae583eb216f44", @"/Views/_ViewImports.cshtml")]
    public class Views_Anuncios_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GerenciadorDeAnuncio.Models.Anuncio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Anuncio</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Marca.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Modelo.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorDeCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ValorDeCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorDeVenda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ValorDeVenda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoCombustivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TipoCombustivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataVenda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataVenda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dc54a638a44b09340ba4c2fdb4883c5c8addbfb10804", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6dc54a638a44b09340ba4c2fdb4883c5c8addbfb11071", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 65 "C:\Users\Vitória\Documents\software\testeQuestor\GerenciadorDeAnuncio\GerenciadorDeAnuncio\Views\Anuncios\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dc54a638a44b09340ba4c2fdb4883c5c8addbfb12898", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GerenciadorDeAnuncio.Models.Anuncio> Html { get; private set; }
    }
}
#pragma warning restore 1591