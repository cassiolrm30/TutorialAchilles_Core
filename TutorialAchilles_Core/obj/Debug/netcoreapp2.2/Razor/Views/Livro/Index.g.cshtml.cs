#pragma checksum "C:\Users\Cassio\source\repos\TutorialAchilles_Core\TutorialAchilles_Core\Views\Livro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b407baecbf815e658853c393ca7a5dc0d6c8d29f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livro_Index), @"mvc.1.0.view", @"/Views/Livro/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Livro/Index.cshtml", typeof(AspNetCore.Views_Livro_Index))]
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
#line 1 "C:\Users\Cassio\source\repos\TutorialAchilles_Core\TutorialAchilles_Core\Views\_ViewImports.cshtml"
using TutorialAchilles_Core;

#line default
#line hidden
#line 2 "C:\Users\Cassio\source\repos\TutorialAchilles_Core\TutorialAchilles_Core\Views\_ViewImports.cshtml"
using TutorialAchilles_Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b407baecbf815e658853c393ca7a5dc0d6c8d29f", @"/Views/Livro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24639868f52f75398d13959991e0828d3d185a19", @"/Views/_ViewImports.cshtml")]
    public class Views_Livro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Livro/Salvar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formCrud"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ControlarGrid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Cassio\source\repos\TutorialAchilles_Core\TutorialAchilles_Core\Views\Livro\Index.cshtml"
  
    ViewBag.Title = "Listar Livros";

#line default
#line hidden
            BeginContext(45, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(50, 13, false);
#line 4 "C:\Users\Cassio\source\repos\TutorialAchilles_Core\TutorialAchilles_Core\Views\Livro\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(63, 2043, true);
            WriteLiteral(@"</h2>

<div id=""gridDados-header"" class=""bootgrid-header container-fluid"">
    <div class=""row"" style=""height:70px;"">
        <div class=""col-sm-4 actionBar"">
            <div class=""search form-group"">
                <div class=""input-group"">
                    <span class=""icon glyphicon input-group-addon glyphicon-search""></span>
                    <input type=""text"" class=""search-field form-control"" style=""width:200px;"" placeholder=""Pesquisar"">
                </div>
            </div>
        </div>
        <div class=""col-sm-4 actionBar"" style=""text-align:center;"">
            <div class=""actions btn-group"">
                <button class=""btn btn-default"" type=""button"" title=""Atualizar"">
                    <span class=""icon glyphicon glyphicon-refresh""></span>
                </button>
                <div class=""dropdown btn-group"" id=""grp1""></div>
                <div class=""dropdown btn-group"" id=""grp2""></div>
            </div>
        </div>
        <div class=""col-sm-4 act");
            WriteLiteral(@"ionBar"" style=""text-align:right;"">
            <a href=""#"" class=""btn btn-success"" data-action=""Create"" id=""btnNovo"">
                <span class=""glyphicon glyphicon-plus""></span>
                Novo Livro
            </a>
        </div>
    </div>
</div>

<div id=""divGrid""></div>

<div id=""gridDados-footer"" class=""bootgrid-footer container-fluid"">
    <div class=""row"">
        <div class=""col-sm-6""></div>
        <div class=""col-sm-6 infoBar""><div class=""infos""></div></div>
    </div>
</div>

<div id=""conteudoModal"">
    <div class=""modal fade"" id=""myModal"" role=""dialog"">
        <div class=""modal-dialog"">
            <div class=""form-horizontal"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    <h4><span class=""glyphicon glyphicon-lock""></span> Cadastro</h4>
                </div>
                <div class=""modal-body"" style=""padding:40px 50px;"">
                    ");
            EndContext();
            BeginContext(2106, 1996, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b407baecbf815e658853c393ca7a5dc0d6c8d29f8373", async() => {
                BeginContext(2174, 1746, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label class=""control-label col-md-2"">Título</label>
                            <div class=""col-md-10"">
                                <input type=""text"" class=""form-control"" style=""width:100px;"" id=""Titulo"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-2"">Autor</label>
                            <div class=""col-md-10"">
                                <input type=""text"" class=""form-control"" style=""width:100px;"" id=""Autor"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-2"">Ano de Edição</label>
                            <div class=""col-md-10"">
                                <input type=""text"" class=""form-control"" style=""width:100px;"" id=""AnoEdicao"">
  ");
                WriteLiteral(@"                          </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-2"">Valor</label>
                            <div class=""col-md-10"">
                                <input type=""text"" class=""form-control"" style=""width:100px;"" id=""Valor"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-2"">Gênero</label>
                            <div class=""col-md-10"">
                                <select id=""GeneroId"" class=""form-control"">
                                    ");
                EndContext();
                BeginContext(3920, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b407baecbf815e658853c393ca7a5dc0d6c8d29f10604", async() => {
                    BeginContext(3938, 15, true);
                    WriteLiteral("Teste de Genero");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3962, 133, true);
                WriteLiteral("\r\n                                </select>\r\n                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4102, 262, true);
            WriteLiteral(@"
                </div>
                <div class=""modal-footer"" style=""text-align:center;"">
                    <button type=""button"" class=""btn btn-default"">Salvar</button>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4383, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(4385, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b407baecbf815e658853c393ca7a5dc0d6c8d29f14176", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4430, 153, true);
                WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function ()\r\n    {\r\n        definirAgrupamento();\r\n        definirGrid(1);\r\n    });\r\n</script>\r\n");
                EndContext();
            }
            );
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