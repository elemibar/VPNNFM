#pragma checksum "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c80a89177d21f8f33a04a61b9b93e7ed4c9a30c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Find), @"mvc.1.0.view", @"/Views/Shared/_Find.cshtml")]
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
#line 2 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
using Dominio.EntidadesNegocio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c80a89177d21f8f33a04a61b9b93e7ed4c9a30c7", @"/Views/Shared/_Find.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Find : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Client.Models.ViewModelActividad>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 5 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
  int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c80a89177d21f8f33a04a61b9b93e7ed4c9a30c75031", async() => {
                WriteLiteral(@"

            <div class=""form-group col-md"">
                <label class=""col-sm"" for=""txtIp"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">IP</span>
                </label>
                <div class=""inline"">
                <!--<input class=""form-control mt-n3"" id=""txtIp"" type=""text"" name=""Change"" placeholder=""IP""> <!--value=""");
#nullable restore
#line 15 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                                                                                                                   Write(Model.Ips);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"-->\n                ");
#nullable restore
#line 16 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
           Write(Html.TextBoxFor(c => c.Change , htmlAttributes : new { @id = "txtIp", @class="btn btn-outline-primary btn-circle btn-sm"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                <input type=\"button\" id=\"addIPToList\" value=\"+\" class=\"btn btn-outline-primary btn-circle btn-sm\" onclick=\"javascript:addIPToListf(); return false;\">  <!-- onclick=\"location.href=\'");
#nullable restore
#line 17 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                                                                                                                                                                                               Write(Url.Action("RenderSearch","Actividad", Model));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'"">-->
                </div>
            </div>

            <div class=""form-group col-md"">
                <label class=""col-sm"" for=""txtIp"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">IPs</span>
                </label>
                <!--<input type=""TextBox"" id=""txtbListIPs"" class=""form-control mt-n3"">-->
                <div class=""panel panel-default border mt-n3"">
                    <table id=""tableIPs"" class=""panel-body"" width=""100%"">
");
#nullable restore
#line 28 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                      
                        foreach (var item in Model.Ips.ToList())
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\n                                <td>\n                                    ");
#nullable restore
#line 33 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                               Write(Html.TextBoxFor(o => o.Ips[i], htmlAttributes : new { @class = "ipSTd"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                                <td>
                                    <button type=""button"" id=""removeIPFromList"" value=""-"" class=""btn btn-outline-danger btn-circle btn-sm"" onclick=""javascript:removeIPFromListf(); return false;"">-</button>
                                </td>
                            </tr>
");
#nullable restore
#line 39 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                            i++;
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </table>

                </div>
            </div>


            <div class=""form-group col-md"">
                <label class=""col-sm"" for=""dateAlta"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">Inicio</span>
                </label>
                <!--<input class=""form-control mt-n3"" id=""dateAlta"" type=""date"" name=""Inicio"" value=""");
#nullable restore
#line 52 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                                                                                                Write(Model.Inicio);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"/>-->\n                ");
#nullable restore
#line 53 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
           Write(Html.EditorFor(i => i.Inicio, new { @class = "form-control mt-n3"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>

            <div class=""form-group col-md"">
                <label class=""col-sm"" for=""dateBaja"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">Fin</span>
                </label>
                <!-- <input class=""form-control mt-n3"" id=""dateBaja"" type=""date"" name=""Fin"" value=""");
#nullable restore
#line 60 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                                                                                              Write(Model.Fin);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"/> -->\n                ");
#nullable restore
#line 61 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
           Write(Html.EditorFor(i => i.Fin, new { @class = "form-control mt-n3"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>

            <div class=""form-group col-md"">
                <label for=""Tipo"" class=""col-sm"">
                    <span class=""h6 small bg-white text-muted pt-1 pl-2 pr-2"">Tipo</span>
                </label>
                    <select class=""form-control mt-n3"" disabled name=""Tipo"">
");
#nullable restore
#line 69 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                         foreach (VPN.EnumTipo tip in Enum.GetValues(typeof(VPN.EnumTipo)))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                             if(tip.GetHashCode() == 1)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c80a89177d21f8f33a04a61b9b93e7ed4c9a30c711694", async() => {
#nullable restore
#line 73 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
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
#line 73 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                                   WriteLiteral(tip);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 74 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c80a89177d21f8f33a04a61b9b93e7ed4c9a30c714158", async() => {
#nullable restore
#line 77 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
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
#line 77 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                                   WriteLiteral(tip);

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
#line 78 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\n            </div>\n\n            <div class=\"form-group col-md\">\n                <input class=\"btn-outline-primary form-control mt-3\" id=\"btn_buscar\" type=\"submit\" value=\"Buscar\">\n            </div>\n\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>



<script type=""text/javascript"">

function addIPToListf()
{
    let newIp = document.querySelector(""#txtIp"").value;


    if( newIp != null && newIp != """" && newIp.length >0)
    {
        console.log(""Bien"");
        
        let newBtn = '<button type=""button"" id=""removeIPFromList"" value=""-"" class=""btn btn-outline-danger btn-circle btn-sm text-right"" onclick=""javascript:removeIPFromListf(");
#nullable restore
#line 104 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
                                                                                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("); return false;\">-</button>\';\n        console.log(newBtn);\n\n        let newHtml = \"<tr><td>\" + newIp + \"</td><td>\" + newBtn + \"</td></tr>\";\n        console.log(newHtml);\n    \n        document.querySelector(\"#tableIPs\").innerHTML += newHtml;\n\n    \n");
#nullable restore
#line 113 "/home/ebarcelona/Proyectos/NET.CORE/VPNNFM/Client/Views/Shared/_Find.cshtml"
          i++;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        RequestChangeVisibilityAjaxCall();
    }

}

function removeIPFromListf(){}

function RequestChangeVisibilityAjaxCall() { 
        /*var IPs = new Array();
        var miChange = document.querySelector(""#txtIp"").value;
        var IPsTDs = document.querySelectorAll("".ipSTd"");
        console.log(""IPsTDs: "" + IPsTDs);
        if(IPsTDs != null && IPsTDs.length > 0)
        {
            for(let i = 0; i < IPsTDs.length; i++)
            {
                IPs.push(`Ips[${i}] : '${IPsTDs[i].value}'`);
                console.log(`Ips[${i}] : '${IPsTDs[i].value}'`);
            }
        }*/

        var IPs = new Array();
        $(""#tableIPs TR"").each(function(){
            var row = $(this);
            //IPs.push(row.find(""TD"").eq(0).html().value);
            //IPs.push(""row.find(""TD"").eq(0).html()"");
        });

        //console.log(""TablaIPS: "" + TabIPs);
/*
{""vpNs"":[],""ips"":[""0.0.0.0""],""inicio"":""0001-01-01T00:00:00"",""fin"":""0001-01-01T00:00:00"",""tipo"":0,""change"":null}
        var vma = JSON.str");
            WriteLiteral(@"ingify(
            {
                VPN: {Ip: '', Usuario: '', Nombre: '', Dependencia: '', Direccion: '', Gabinete: '', Alta: '', Baja: '', Tipo: '', Actividades: {}},
                IPs:{}, 
                Inicio: '',
                Fin: '',
                Tipo: '',
                Change: miChange
                });
*/

//{vma:{""vpNs"":[],""ips"":[],""inicio"":""0001-01-01T00:00:00"",""fin"":""0001-01-01T00:00:00"",""tipo"":0,""change"":""HOLA""}},

        console.log(""IPs: "" + IPs);
        console.log(""IPs: "" + JSON.stringify(IPs));

        var data = {
        ""vpNs"":[],
        ""ips"":[],
        ""inicio"":""0001-01-01T00:00:00"",
        ""fin"":""0001-01-01T00:00:00"",
        ""tipo"":0,
        ""change"":""4.4.4.4""
        }
        var dataType = 'application/json; charset=utf-8';

        $.ajax({
            type: 'POST',
            url: ""../Actividad/RenderSearch"",
            dataType: 'json',
            contentType: dataType,
            data: JSON.stringify(data),
            success: function (data) {
      ");
            WriteLiteral("          //$(\'#DepartmentManagement\').html(data);\n                console.log(\"Success\");\n            }\n        });\n    }\n\n\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Client.Models.ViewModelActividad> Html { get; private set; }
    }
}
#pragma warning restore 1591