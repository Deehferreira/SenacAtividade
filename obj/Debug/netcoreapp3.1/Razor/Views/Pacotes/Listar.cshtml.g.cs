#pragma checksum "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\Pacotes\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b5a5a3dafd8eb632a4d72e685add394ce68b0e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacotes_Listar), @"mvc.1.0.view", @"/Views/Pacotes/Listar.cshtml")]
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
#line 1 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\_ViewImports.cshtml"
using EstudoBC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\_ViewImports.cshtml"
using EstudoBC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b5a5a3dafd8eb632a4d72e685add394ce68b0e1", @"/Views/Pacotes/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17e3b06b903cdbd4d309a124ac49f34ee172d232", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacotes_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pacotes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\Pacotes\Listar.cshtml"
  
    ViewData["Title"] = "Listagem de Pacotes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Listagem de Pacotes</h2>
<table class=""table table-bordered table-stripped"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Origem</th>
            <th>Destino</th>
            <th>Atrativos</th>
            <th>Saida</th>
            <th>Retorno</th>
            <th>usuario</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\Pacotes\Listar.cshtml"
         foreach (Pacotes p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\Pacotes\Listar.cshtml"
               Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\Pacotes\Listar.cshtml"
               Write(p.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\Pacotes\Listar.cshtml"
               Write(p.Origem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\Pacotes\Listar.cshtml"
               Write(p.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\Pacotes\Listar.cshtml"
               Write(p.Atrativos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\Pacotes\Listar.cshtml"
               Write(p.Saida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\Pacotes\Listar.cshtml"
               Write(p.Retorno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\Pacotes\Listar.cshtml"
               Write(p.usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\ddcf1\OneDrive\Área de Trabalho\TECNICO SENAC\EstudoBC\Views\Pacotes\Listar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pacotes>> Html { get; private set; }
    }
}
#pragma warning restore 1591