#pragma checksum "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "971a55646b6bac9a9944cc296efc913976e00831"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VPN_Index), @"mvc.1.0.view", @"/Views/VPN/Index.cshtml")]
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
#line 2 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
using Dominio.EntidadesNegocio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971a55646b6bac9a9944cc296efc913976e00831", @"/Views/VPN/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_VPN_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Client.Models.ViewModelVPN>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Icons/download.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("16"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("16"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
  
    ViewData["Title"] = "VPNs";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>VPNs</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "971a55646b6bac9a9944cc296efc913976e008316329", async() => {
                WriteLiteral("Agregar VPN");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>

<!-- <p class=""small text-danger"">Debido a la inconsistencia de los datos en la BD sólo se muestra la actividad de los modems.</p> -->
<!-- ////////////////////// BUSQUEDA //////////////////////////////// -->

<div class=""row"">
    <div class=""col-md"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "971a55646b6bac9a9944cc296efc913976e008317744", async() => {
                WriteLiteral(@"

            <div class=""form-group col-md-2"">
                <label class=""col-sm-2"" for=""txtIp"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">IP</span>
                </label>
                <input class=""form-control mt-n3"" id=""txtIp"" type=""text"" name=""PVPN.Ip"" placeholder=""IP"" />
            </div>

            <div class=""form-group col-md-2"">
                <label class=""col-sm-2"" for=""nombre"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">Nombre</span>
                </label>
                <input class=""form-control mt-n3"" id=""nombre"" type=""text"" name=""VPN.nombre"" placeholder=""Nombre"" />
            </div>

            <div class=""form-group col-md-2"">
                <label class=""col-sm-2"" for=""dateAlta"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">Fecha_Alta</span>
                </label>
                <input class=""form-control mt-n3"" id=""dateAlta"" type=""date"" name=""VPN.Alta"" placeholder=""F");
                WriteLiteral(@"echa"" />
            </div>

            <div class=""form-group col-md-2"">
                <label class=""col-sm-2"" for=""dateBaja"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">Fecha_Baja</span>
                </label>
                <input class=""form-control mt-n3"" id=""dateBaja"" type=""date"" name=""VPN.Baja"" placeholder=""Fecha"" />
            </div>

            <div class=""form-group col-md-2"">
                <label for=""Tipo"" class=""col-sm-2"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">Tipo</span>
                </label>

                <select class=""form-control mt-n3"" name=""VPN.Tipo"">
");
#nullable restore
#line 55 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
                     foreach (VPN.EnumTipo tip in Enum.GetValues(typeof(VPN.EnumTipo)))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "971a55646b6bac9a9944cc296efc913976e0083110125", async() => {
#nullable restore
#line 57 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
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
#line 57 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
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
#line 58 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\n\n            </div>\n\n            <div class=\"form-group col-md-2\">\n                <input class=\"btn-outline-primary form-control mt-3\" id=\"btn_buscar\" type=\"submit\" value=\"Buscar\">\n            </div>\n\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n<!-- ///////////////////////////////////////////// -->\n\n<p class=\"text-danger\">");
#nullable restore
#line 73 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
                  Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n\n<!-- //////////// BOTON DESACARGA ////////////// -->\n\n<button class=\"btn btn-outline-primary mb-3\" type=\"button\" onclick=\"exportData()\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "971a55646b6bac9a9944cc296efc913976e0083114215", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    Descargar\n</button>\n\n<!-- ////////////// TABLA ////////////////////// -->\n<table class=\"table\">\n    <thead style=\"position: sticky;top: 0;\" class=\"thead-dark\">\n        <tr>\n\n            <th class=\"header\" scope=\"col\">\n                ");
#nullable restore
#line 88 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VPN.Ip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th class=\"header\" scope=\"col\">\n                ");
#nullable restore
#line 91 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VPN.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th class=\"header\" scope=\"col\">\n                ");
#nullable restore
#line 94 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VPN.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th class=\"header\" scope=\"col\">\n                ");
#nullable restore
#line 97 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VPN.Dependencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th class=\"header\" scope=\"col\">\n                ");
#nullable restore
#line 100 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VPN.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th class=\"header\" scope=\"col\">\n                ");
#nullable restore
#line 103 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VPN.Gabinete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th class=\"header\" scope=\"col\">\n                ");
#nullable restore
#line 106 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VPN.Alta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th class=\"header\" scope=\"col\">\n                ");
#nullable restore
#line 109 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VPN.Baja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th class=\"header\" scope=\"col\">\n                ");
#nullable restore
#line 112 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VPN.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 118 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
         foreach (var item in Model.VPNs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n\n                <td>\n                    ");
#nullable restore
#line 123 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
               Write(item.Ip.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 126 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 129 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 132 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dependencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 135 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 138 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gabinete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 141 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
                     if(item.Alta != null && item.Alta.ToString() != "1/1/0001 00:00:00")
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
                   Write(item.Alta.ToString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
                                             
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n                <td>\n");
#nullable restore
#line 147 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
                     if(item.Baja != null && item.Baja.ToString() != "1/1/0001 00:00:00")
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
                   Write(item.Baja.ToString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
                                             
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n                <td>\n                    ");
#nullable restore
#line 153 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 156 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
               Write(Html.ActionLink("Actividad", "Index", "Actividad", new { ip=item.Ip, alta=item.Alta, baja=item.Baja, pagina=0, tamanioPag=50}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 157 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
               Write(Html.ActionLink("Modificar", "Edit", "VPN", new { ip=item.Ip, alta=item.Alta, baja=item.Baja }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 160 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n\n<p>");
#nullable restore
#line 165 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
Write(ViewBag.mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n<!-- //////////////////////////////////////////// -->\n\n<!-- ////////////// SCRIPT ////////////////////// -->\n<script type=\"text/javascript\">\nfunction exportData(){\n    var currentdate = new Date();\n    var JVPNS = ");
#nullable restore
#line 172 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/VPN/Index.cshtml"
           Write(Html.Raw(Json.Serialize(@Model.VPNs)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    
    csvContent = ""data:text/csv;charset=utf-8,"";
    /* agrega el delimitador de columna como "","" y cada row separada por un salto de linea(\r\n) */
    /* valida ademas si los campos son nulos agrega celda vacia y si las fechas son ""indefinidas"" tambien es celda vacia */
    JVPNS.forEach(function(rowArray){
        row =   (rowArray.ip===null?"" "":rowArray.ip)+"",""+
                (rowArray.usuario===null?"" "":rowArray.usuario)+"",""+
                (rowArray.nombre===null?"" "":rowArray.nombre)+"",""+
                (rowArray.dependencia===null?"" "":rowArray.dependencia)+"",""+
                (rowArray.direccion===null?"" "":rowArray.direccion)+"",""+
                (rowArray.gabinete===null?"" "":rowArray.gabinete)+"",""+
                (rowArray.alta===""0001-01-01T00:00:00""?"" "":rowArray.alta)+"",""+
                (rowArray.baja===""0001-01-01T00:00:00""?"" "":rowArray.baja)+"",""+
                (rowArray.tipo===1?""Modem"":""Certificado"");
        
        csvContent += row + ""\r\n"";
    });

    /* crea un nodo DOM <");
            WriteLiteral(@"a> oculto y le setea el atributo download */
    var encodedUri = encodeURI(csvContent);
    var link = document.createElement(""a"");
    link.setAttribute(""href"", encodedUri);
    
    link.setAttribute(""download"", ""reporte_VPNs_""+currentdate.getDate()+""""+
                (currentdate.getMonth()+1)+""""+
                currentdate.getFullYear()+""""+
                currentdate.getHours()+""""+
                currentdate.getMinutes()+"".csv"");
    document.body.appendChild(link);
    /* descarga el archivo de datos con nombre ""reporte_VPNs.csv"" */
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Client.Models.ViewModelVPN> Html { get; private set; }
    }
}
#pragma warning restore 1591
