#pragma checksum "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b69aa6b66a060e77f0e046e657187a8ac1de500"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
#line 1 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b69aa6b66a060e77f0e046e657187a8ac1de500", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 522, true);
            WriteLiteral(@"
    <main>
        <h2> Dashboard </h2>

        <div id=""pedidos"">
            <table id=""parte1"">
                <thead>
                    <tr>
                        <th> Contratante </th>
                        <th> Telefone </th>
                        <th> E-mail </th>
                        <th> Empresa </th>
                        <th> Público Estimado </th>
                        <th> Tipo de Evento </th>
                    </tr>
                </thead>

                <tbody>
");
            EndContext();
#line 20 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                     foreach (var evento in Model.Eventos)
                    {

#line default
#line hidden
            BeginContext(654, 63, true);
            WriteLiteral("                        <tr>\r\n                            <td> ");
            EndContext();
            BeginContext(718, 19, false);
#line 23 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                            Write(evento.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(737, 41, true);
            WriteLiteral(" </td>\r\n                            <td> ");
            EndContext();
            BeginContext(779, 23, false);
#line 24 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                            Write(evento.Cliente.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(802, 41, true);
            WriteLiteral(" </td>\r\n                            <td> ");
            EndContext();
            BeginContext(844, 20, false);
#line 25 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                            Write(evento.Cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(864, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
            BeginContext(905, 22, false);
#line 26 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                            Write(evento.Cliente.Empresa);

#line default
#line hidden
            EndContext();
            BeginContext(927, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
            BeginContext(968, 14, false);
#line 27 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                            Write(evento.Publico);

#line default
#line hidden
            EndContext();
            BeginContext(982, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
            BeginContext(1023, 17, false);
#line 28 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                            Write(evento.TipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 30 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(1101, 584, true);
            WriteLiteral(@"                </tbody>
            </table>
            <table id=""parte2"">
                <thead>
                    <tr>
                        <th> Data de Início </th>
                        <th> Data de Término </th>
                        <th> Iluminação </th>
                        <th> Som </th>
                        <th> Limpeza </th>
                        <th> Valor da Locação</th>
                        <th> Aceitar </th>
                        <th> Recusar </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 47 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                     foreach (var evento in Model.Eventos)
                    {

#line default
#line hidden
            BeginContext(1768, 63, true);
            WriteLiteral("                        <tr>\r\n                            <td> ");
            EndContext();
            BeginContext(1832, 17, false);
#line 50 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                            Write(evento.DataInicio);

#line default
#line hidden
            EndContext();
            BeginContext(1849, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
            BeginContext(1890, 18, false);
#line 51 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                            Write(evento.DataTermino);

#line default
#line hidden
            EndContext();
            BeginContext(1908, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
            BeginContext(1949, 17, false);
#line 52 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                            Write(evento.Iluminacao);

#line default
#line hidden
            EndContext();
            BeginContext(1966, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
            BeginContext(2007, 10, false);
#line 53 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                            Write(evento.Som);

#line default
#line hidden
            EndContext();
            BeginContext(2017, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
            BeginContext(2058, 14, false);
#line 54 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                            Write(evento.Limpeza);

#line default
#line hidden
            EndContext();
            BeginContext(2072, 90, true);
            WriteLiteral(" </td>\r\n                            <td> 2500,00 </td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2162, "\'", 2224, 1);
#line 56 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2169, Url.Action("Aprovar", "Evento", new {id = @evento.Id}), 2169, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2225, 74, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2299, "\'", 2362, 1);
#line 57 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2306, Url.Action("Reprovar", "Evento", new {id = @evento.Id}), 2306, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2363, 95, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                        </tr>                        \r\n");
            EndContext();
#line 59 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                    }                    

#line default
#line hidden
            BeginContext(2501, 188, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n        <section id=\"status\">\r\n            <div id=\"aprovados\">\r\n                <h3> Aprovados</h3>\r\n                <p> ");
            EndContext();
            BeginContext(2690, 22, false);
#line 67 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
               Write(Model.EventosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(2712, 123, true);
            WriteLiteral(" </p>\r\n            </div>\r\n\r\n            <div id=\"reprovados\">\r\n                <h3> Reprovados </h3>\r\n                <p> ");
            EndContext();
            BeginContext(2836, 23, false);
#line 72 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
               Write(Model.EventosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(2859, 121, true);
            WriteLiteral(" </p>\r\n            </div>\r\n\r\n            <div id=\"pendentes\">\r\n                <h3> Pendentes </h3>\r\n                <p> ");
            EndContext();
            BeginContext(2981, 22, false);
#line 77 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
               Write(Model.EventosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(3003, 83, true);
            WriteLiteral(" </p>\r\n            </div>\r\n        </section>\r\n\r\n        <p>Eventos atualizados em ");
            EndContext();
            BeginContext(3087, 12, false);
#line 81 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                             Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(3099, 21, true);
            WriteLiteral("</p>\r\n\r\n    </main>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
