#pragma checksum "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdbb3a9a3c33b79de10c561a75f91af039c5d48f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdbb3a9a3c33b79de10c561a75f91af039c5d48f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 972, true);
            WriteLiteral(@"    <main>
        <div id=""sobre"">
            <p>Desde 2010, o Rolê Top vem trazendo as melhores festas e eventos a seu público e vem sendo sucesso entre
                todos.
                Baladas, casamentos, apresentações, entre outros eventos com muita qualidade, segurança e diversão.</p>
        </div>

        <section id=""eventos"">
            <h2> Eventos </h2>
            <ol>
                <li>16/08 - Sextanejo - das 21 horas as 03 horas</li>
                <li>17/08 - White Party (Balada eletrônica) - das 21 horas as 04 horas</li>
                <li>18/08 - Casamento - Evento fechado</li>
                <li>22/08 - Apresentação - Evento fechado</li>
                <li>23/08 - Sextanejo - das 21 horas as 03 horas</li>
                <li>24/08 - Casamento - Evento fechado</li>
            </ol>
        </section>

        <section id=""serviços"">
            <h2> Serviços </h2>
            <ul>
                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 972, "\'", 1010, 1);
#line 23 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 979, Url.Action("Index","Servicos"), 979, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1011, 46, true);
            WriteLiteral("> Iluminação </a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1057, "\'", 1095, 1);
#line 24 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1064, Url.Action("Index","Servicos"), 1064, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1096, 39, true);
            WriteLiteral("> Som </a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1135, "\'", 1173, 1);
#line 25 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1142, Url.Action("Index","Servicos"), 1142, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1174, 43, true);
            WriteLiteral("> Limpeza </a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1217, "\'", 1255, 1);
#line 26 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1224, Url.Action("Index","Servicos"), 1224, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1256, 50, true);
            WriteLiteral("> Estacionamento </a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1306, "\'", 1344, 1);
#line 27 "C:\Users\aleli\OneDrive\Documentos\Arquivos-DS-Senai\Exercicios - html-mvc\RoleTopMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1313, Url.Action("Index","Servicos"), 1313, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1345, 780, true);
            WriteLiteral(@"> Acessibilidade </a></li>
            </ul>
        </section>


        <section id=""perguntas"">
            <h2> Perguntas Frequentes </h2>

            <strong>Onde estaciono meu veículo ?</strong>
            <p>Somos conveniados ao estacionamento Carpark, que tem um amplo espaço dedicado a seu veículo.</p>
            <strong>Sou deficiente, tenho acesso livre ?</strong>
            <p>O local está preparado para receber deficientes visuais e físicos, com rampas de acesso e piso tátil.</p>
            <strong>É permitido a entrada de menores de idade ?</strong>
            <p>O local recebe vários tipos de eventos, por isso é recomendável que seja verificado a faixa etária de
                acordo com o evento.</p>
        </section>
    </main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
