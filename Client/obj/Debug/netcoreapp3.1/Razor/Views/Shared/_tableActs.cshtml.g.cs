#pragma checksum "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8155a7e2ed215ae72d5361e69da426bab270a12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__tableActs), @"mvc.1.0.view", @"/Views/Shared/_tableActs.cshtml")]
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
#line 1 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/_ViewImports.cshtml"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
using Dominio.EntidadesNegocio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8155a7e2ed215ae72d5361e69da426bab270a12", @"/Views/Shared/_tableActs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__tableActs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VMActividad>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmBusc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Icons/download.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("16"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("16"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Icons/angulo-doble-pequeno-izquierdo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Icons/angulo-pequeno-izquierdo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Icons/angulo-pequeno-derecho.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Icons/angulo-doble-pequeno-derecho.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \n <!-- /////////////////////// BUSQUEDA //////////////////////////////////// -->\n<div class=\"row\">\n    <div class=\"col-md\">\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8155a7e2ed215ae72d5361e69da426bab270a127016", async() => {
                WriteLiteral(@"<!--enctype=""multipart/form-data"" method=""post"" asp-action=""AddVPN"">-->

            <div class=""form-group col-md-1"">
                <input type=""button"" id=""btnAddIPToList"" value=""+""
                    class=""form-control btn btn-outline-primary btn-circle mt-3"">
            </div>

            <div class=""form-group col-md-3"">
                <label class=""col-sm"" for=""txtIp"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">IP</span>
                </label>
                <div class=""inline"">
                    <input class=""form-control mt-n3"" id=""txtIp"" type=""text"" name=""NIp"" placeholder=""IP"">
                </div>
            </div>

            <div class=""form-group col-md-2"">
                <label class=""col-sm"" for=""dateAlta"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">Inicio</span>
                </label>
                <input class=""form-control mt-n3"" id=""dtInicio"" type=""date"" name=""NIni"" />
            </div>

            ");
                WriteLiteral(@"<div class=""form-group col-md-2"">
                <label class=""col-sm"" for=""dateBaja"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">Fin</span>
                </label>
                <input class=""form-control mt-n3"" id=""dtFin"" type=""date"" name=""NFin"" />
            </div>

            <div class=""form-group col-md-2"">
                <label for=""Tipo"" class=""col-sm"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">Tipo</span>
                </label>
                <select class=""form-control mt-n3"" name=""NTipo"" id=""selTipo"">
");
#nullable restore
#line 43 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                     foreach (VPN.EnumTipo tip in Enum.GetValues(typeof(VPN.EnumTipo)))
                    {
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8155a7e2ed215ae72d5361e69da426bab270a129358", async() => {
#nullable restore
#line 46 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                                                      Write(tip);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                           WriteLiteral(tip.GetHashCode());

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 47 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>

            <div class=""form-group col-md-2"">
                <input type=""button"" id=""btnBuscar"" value=""Buscar"" valor=""0""
                    class=""form-control btn btn-outline-primary btn-circle mt-3"">
            </div>

        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            \n \n           <!-- //////////////// LISTADO de Datos de busqueda (VPNs) ///////////////////////////// -->\n \n        <table class=\"table table-striped \" id=\"tabVpns\">\n            <tbody>\n");
#nullable restore
#line 64 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                  
                    int i = 0;
                    foreach(VMPlainVPN v in Model.PVPNs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <tr>
                            <td class=""col-sm-1"">
                                <button type=""button"" id=""removeIPFromList"" value=""-"" class=""btn btn-outline-danger btn-circle btn-sm text-right"" onclick=""javascript:removeIPFromListf(this); return false;"">-</button>
                            </td>
                            <td class=""col-sm-3"">
                                ");
#nullable restore
#line 73 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                           Write(Html.DisplayFor(x => v.Ip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td class=\"col-sm-3\">\n                                ");
#nullable restore
#line 76 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                           Write(Html.DisplayFor(x => v.Alta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td class=\"col-sm-3\">\n                                ");
#nullable restore
#line 79 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                           Write(Html.DisplayFor(x => v.Baja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td class=\"col-sm-2\"");
            BeginWriteAttribute("value", " value=\"", 3531, "\"", 3560, 1);
#nullable restore
#line 81 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
WriteAttributeValue("", 3539, v.Tipo.GetHashCode(), 3539, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                ");
#nullable restore
#line 82 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                           Write(Html.DisplayFor(x => v.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 85 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                        i++;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        
            </tbody>
        </table>
            
    </div>
</div>
     
<div class=""container-fluid"">
    <div class=""row"">
        <!-- //////////// BOTON DESACARGA ////////////// -->
        <div class=""col md-3"">
            <button id=""btnDownload"" class=""btn btn-outline-primary mb-3"" type=""button"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8155a7e2ed215ae72d5361e69da426bab270a1216217", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                Descargar
            </button>
        </div>
        <!-- //////////////////////////////////////////////// -->
        <!-- //////////// CONTROLES PAGINACION ////////////// -->
        <div class=""col md-9"">
            <button id=""btnMenos10"" class=""btn mb-2"" type=""button"" ");
#nullable restore
#line 107 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                                                               Write(Model.pagina>9?null:"disabled");

#line default
#line hidden
#nullable disable
            WriteLiteral(" valor=\"");
#nullable restore
#line 107 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                                                                                                        Write(Model.pagina-10);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8155a7e2ed215ae72d5361e69da426bab270a1218332", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "valor", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 108 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
AddHtmlAttributeValue("", 4618, Model.pagina-10, 4618, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </button>\n            <button id=\"btnMenos1\" class=\"btn mb-2\" type=\"button\" ");
#nullable restore
#line 110 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                                                              Write(Model.pagina>0?null:"disabled");

#line default
#line hidden
#nullable disable
            WriteLiteral(" valor=\"");
#nullable restore
#line 110 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                                                                                                       Write(Model.pagina-1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8155a7e2ed215ae72d5361e69da426bab270a1220696", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "valor", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 111 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
AddHtmlAttributeValue("", 4882, Model.pagina-1, 4882, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </button>\n            <a>");
#nullable restore
#line 113 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
           Write(Model.pagina+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" de ");
#nullable restore
#line 113 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                                Write((Model.cantRows/(Model.tamanioPag))+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n            <button id=\"btnMas1\" class=\"btn mb-2\" type=\"button\" ");
#nullable restore
#line 114 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                                                            Write(((Model.cantRows/Model.tamanioPag)-Model.pagina)>0?null:"disabled");

#line default
#line hidden
#nullable disable
            WriteLiteral(" valor=\"");
#nullable restore
#line 114 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                                                                                                                                         Write(Model.pagina+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8155a7e2ed215ae72d5361e69da426bab270a1223636", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "valor", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 115 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
AddHtmlAttributeValue("", 5258, Model.pagina+1, 5258, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </button>\n            <button id=\"btnMas10\" class=\"btn mb-2\" type=\"button\" ");
#nullable restore
#line 117 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                                                             Write(((Model.cantRows/Model.tamanioPag)-Model.pagina)>9?null:"disabled");

#line default
#line hidden
#nullable disable
            WriteLiteral(" valor=\"");
#nullable restore
#line 117 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
                                                                                                                                          Write(Model.pagina+10);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8155a7e2ed215ae72d5361e69da426bab270a1226069", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "valor", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 118 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_tableActs.cshtml"
AddHtmlAttributeValue("", 5561, Model.pagina+10, 5561, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </button>
        </div>
        <!-- //////////////////////////////////////////////// -->
    </div>
</div>




<!-- //////////////// SCRIPTS PARA BUSQUEDA ///////////////////////////// -->

<script type=""text/javascript"">

document.querySelector('#btnAddIPToList').addEventListener(""click"", addVPNToList);
document.querySelector('#btnBuscar').addEventListener(""click"", buscar);
document.querySelector('#frmBusc').addEventListener(""submit"", buscar);
document.querySelector('#btnMas1').addEventListener(""click"", buscar);
document.querySelector('#btnMas10').addEventListener(""click"", buscar);
document.querySelector('#btnMenos1').addEventListener(""click"", buscar);
document.querySelector('#btnMenos10').addEventListener(""click"", buscar);
document.querySelector('#btnDownload').addEventListener(""click"", download);

function removeIPFromListf(tabIpRow) 
{

    tabIpRow.parentNode.parentNode.remove();

}

function buscar(event)
{
    sendToControl(event, ""../Actividad/Index"");
}

function addVPNToList(event)
{
");
            WriteLiteral(@"    sendToControl(event, ""../Actividad/AddVPN"");
}

function download(event)
{
    sendToControl(event, ""../Actividad/DownloadCSV"");
}

function sendToControl(event, url)
{
    
    event.preventDefault();
    event.stopPropagation();

    var JsonString = """";

    var formJson = returnFormAsJson();
    var tableJson = returnVPNsTableAsJson();

    if ((formJson != null && formJson != """") || (tableJson != null && tableJson != """"))
    {
        JsonString = `{""PVPNs"":[
            `;

        if (formJson != """") JsonString += formJson;

        if (formJson != null && formJson != """" && tableJson != null && tableJson != """")
        {
            JsonString += `,
                `;
        }

        if (tableJson != null && tableJson != """") JsonString += tableJson;


        JsonString += `
                ]`;

        // Nuevo para paginacion
        JsonString += `,
                ""pagina"": ${Number(event.target.getAttribute(""valor""))},
                ""tamanioPag"":50}`;
    }
    else
    {
        // Si e");
            WriteLiteral(@"l formulario de busqueda y la tabla est[an vacias solo se manda el numero de pagina
        JsonString = `{""pagina"": ${Number(event.target.getAttribute(""valor""))},
                ""tamanioPag"":50}`
    }

    
    sendToControlAjax(JsonString, url);

}

function returnFormAsJson()
{

    let newIp = document.querySelector(""#txtIp"").value.trim();
    let newInicio = document.querySelector(""#dtInicio"").value;
    let newFin = document.querySelector(""#dtFin"").value;
    let newTipo = document.querySelector(""#selTipo"").value;
    var newVPN = """";

    if ((newIp != """") || (newInicio != """") || (newFin != """") || newTipo != 0)
    {
        newVPN =
            `{
                ""Ip"": ""${newIp}"",
                ""Alta"": ""${newInicio}"",
                ""Baja"": ""${newFin}"",
                ""Tipo"": ${newTipo}
            }`;
    }
    else
    {
        newVPN = """";
    }

    return newVPN;

}

function returnVPNsTableAsJson()
{

    var tablaRows = document.querySelectorAll(""#tabVpns tbody tr"");
    let newTabIp = """);
            WriteLiteral(@""";
    let newTabInicio = """";
    let newTabFin = """";
    let newTabTipo = """";
    var vpnListJson = """";

    if (tablaRows != null)
    {
        
        if (tablaRows.length > 0)
        {
        

            for (let i = 0; i < tablaRows.length; i++)
            {
                let newTabIp = tablaRows[i].querySelectorAll(""td"")[1].innerHTML.trim();

                let newTabInicio = tablaRows[i].querySelectorAll(""td"")[2].innerHTML.trim();

                let newTabFin = tablaRows[i].querySelectorAll(""td"")[3].innerHTML.trim();

                let newTabTipo = tablaRows[i].querySelectorAll(""td"")[4].attributes.value.value;

        
                vpnListJson +=
                    `{
                        ""Ip"": ""${newTabIp}"",
                        ""Alta"": ""${newTabInicio}"",
                        ""Baja"": ""${newTabFin}"",
                        ""Tipo"": ${newTabTipo}
                    }`;
                if (i != tablaRows.length - 1)
                    vpnListJson += `,
                      ");
            WriteLiteral(@"  `;
            }
        }
        else
        {
            vpnListJson = """";
        }
    }


    return vpnListJson;
}

function sendToControlAjax(data, url)
{

    var dataType = 'application/json; charset=utf-8';
    
    $.ajax({
        type: 'POST',
        url: url,
        //dataType: 'json',
        contentType: dataType,
        data: data,
        success: function (result)
        {
            if(url == ""../Actividad/AddVPN"")
            {
                $('#searchForm').empty();
                $('#searchForm').html(result);
            }
            else if(url == ""../Actividad/DownloadCSV"")
            {
                exportData(result);
            }
                else
                {
                    $('body').empty();
                    $('body').html(result);
                }
        },
        error: function (result)
        {
            console.log(""Error: "");
            console.log(result);
        }
    });

}

function exportData(data){
    var currentdate = new D");
            WriteLiteral(@"ate();
    var JVPNS = data;

    csvContent = ""data:text/csv;charset=utf-8,"";
    /* agrega el delimitador de columna como "","" y cada row separada por un salto de linea(\r\n) */
    /* valida ademas si los campos son nulos agrega celda vacia y si las fechas son ""indefinidas"" tambien es celda vacia */
    csvContent += ""IP,Nombre,Usuario,Dependencia,Direccion,Gabinete,Alta,Baja,Tipo,Inicio,Fin,Destino,Puerto,Protocolo,Segundos,Bytes, Bytes HR\r\n""
    JVPNS.value.forEach(function(rowArray){
        rowArray.actividades.forEach(function(actRowArray){
        
        row =   (rowArray.ip===null?"" "":rowArray.ip)+"",""+
                (rowArray.nombre===null?"" "":rowArray.nombre)+"",""+
                (rowArray.usuario===null?"" "":rowArray.usuario)+"",""+
                (rowArray.dependencia===null?"" "":rowArray.dependencia)+"",""+
                (rowArray.direccion===null?"" "":rowArray.direccion)+"",""+
                (rowArray.gabinete===null?"" "":rowArray.gabinete)+"",""+
                (rowArray.alta===""0001-01-01T00:0");
            WriteLiteral(@"0:00""?"" "":rowArray.alta)+"",""+
                (rowArray.baja===""0001-01-01T00:00:00""?"" "":rowArray.baja)+"",""+
                (rowArray.tipo===1?""Modem"":""Certificado"")+"",""+
                (actRowArray.inicio===null?"" "":actRowArray.inicio)+"",""+
                (actRowArray.fin===null?"" "":actRowArray.fin)+"",""+
                (actRowArray.destino===null?"" "":actRowArray.destino)+"",""+
                (actRowArray.puerto===null?"" "":actRowArray.puerto)+"",""+
                (actRowArray.protocolo===null?"" "":actRowArray.protocolo)+"",""+
                (actRowArray.segundos===null?"" "":actRowArray.segundos)+"",""+
                (actRowArray.bytes===null?"" "":actRowArray.bytes)+"",""+
                (actRowArray.bytesh===null?"" "":actRowArray.bytesh);

        

        csvContent += row + ""\r\n"";
        })
    });

    /* crea un nodo DOM <a> oculto y le setea el atributo download */
    var encodedUri = encodeURI(csvContent);
    var link = document.createElement(""a"");
    link.setAttribute(""href"", encodedUri);
    
   ");
            WriteLiteral(@" link.setAttribute(""download"", ""reporte_actividades_""+currentdate.getDate()+""""+
                (currentdate.getMonth()+1)+""""+
                currentdate.getFullYear()+""""+
                currentdate.getHours()+""""+
                currentdate.getMinutes()+"".csv"");
    document.body.appendChild(link);
    /* descarga el archivo de datos con nombre ""reporte_actividades_.csv"" */
    link.click();    

}


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VMActividad> Html { get; private set; }
    }
}
#pragma warning restore 1591
