#pragma checksum "C:\Users\winicius\Documents\SENAI_Atividades\Back-end\InstaDev_ProjetoGrupo3\Views\Perfil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c72aa159c6b7cf06a27ab4be36b325ac957b399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_Index), @"mvc.1.0.view", @"/Views/Perfil/Index.cshtml")]
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
#line 1 "C:\Users\winicius\Documents\SENAI_Atividades\Back-end\InstaDev_ProjetoGrupo3\Views\_ViewImports.cshtml"
using InstaDev_ProjetoGrupo3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\winicius\Documents\SENAI_Atividades\Back-end\InstaDev_ProjetoGrupo3\Views\_ViewImports.cshtml"
using InstaDev_ProjetoGrupo3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c72aa159c6b7cf06a27ab4be36b325ac957b399", @"/Views/Perfil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de72dde27ce3ce956fa1038ad8814899cf8c285e", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\winicius\Documents\SENAI_Atividades\Back-end\InstaDev_ProjetoGrupo3\Views\Perfil\Index.cshtml"
  
    ViewData["Title"] = "Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral("<header>\r\n    <div class=\"container\">\r\n        <a href=\"#\"><img class=\"logoInstaDev\" src=\"Img/Instadev.png\" alt=\"Logo Instadev\"></a>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c72aa159c6b7cf06a27ab4be36b325ac957b3994031", async() => {
                WriteLiteral("\r\n            <input type=\"text\" placeholder=\"Pesquisar\">\r\n        ");
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
            WriteLiteral(@"
        <div class=""logos"">
            <a href=""#"" class=""logoPagPrincipal""><img src=""Img/PaginaPricipal.png"" alt=""Ir para página principal"" ></a>
            <a href=""#"" class=""logoDirect""><img src=""Img/Direct.png"" alt=""Ir para o direct"" ></a>
            <a href=""#"" class=""logoLocalizacao""><img src=""Img/Localizaçao.png"" alt=""Ver localizações"" ></a>
            <a href=""#"" class=""logoCurtidas""><img src=""Img/Curtidas.png"" alt=""Ver  quem curtiu suas publicações"" ></a>
            <a href=""#"" class=""FotoPerfil""><img src=""Img/FotoPerfil.png"" alt=""Ir para perfil principal""></a>      
        </div>
    </div>
</header>
<div class=""container-bio"">        
    <section class=""biografia"">
        <div class=""fotoPerfil"">
            <img src=""Img/FotoPerfil.png"" alt=""Foto de perfil"">
        </div>
        <div class=""bio2"">
            <div class=""nomeUsuario"">
                <h1>yes_baby</h1>
                <a href=""#"">Editar Perfil</a>
            </div>
            <div class=""pubsegui"">");
            WriteLiteral(@"
                <p class=""nmrpub"">0 Publicações</p>
                <p class=""seguidores"">214 Seguidores</p>
                <p class=""seguindo"">128 Seguindo</p>
            </div>
            <div class=""nomeVerdadeiro"">
                <h2>Marcos Jeeves</h2>
                <a href=""#"">Sair</a>
            </div>
        </div>
    </section>
</div>
<div class=""linha""></div>
<div class=""containerpubs"">
    <div class=""cubospub"">
        <a href=""#""><img class=""iconepub"" src=""Img/IconePub.png"" alt=""Publicações""></a>
        <a href=""#""><p>Publicações</p></a>
    </div>
</div>
<section class=""pubs"">
    <div class=""container"">
        <div class=""publicacoes"">
            <img src=""Img/FotoDeMarcosJeeves.png"" alt=""Foto de Marcos Jeeves fazendo numero cinco com a mão escrito Yes Baby, Thank You."">
            <div class=""comentuser"">
                <div class=""nomeuser-localidade"">
                    <img class=""fotoperfilpub"" src=""Img/FotoPerfil.png"" alt=""Foto de perfil de Marcos Je");
            WriteLiteral(@"eves"">
                    <div class=""titulos-nomeuser"">
                        <h2>Marcoes Jeeves</h2>
                        <h3>Rio de Janeiro, Brazil</h3>
                    </div>
                </div>
                <div class=""coments"">
                    <a href=""#""><img src=""Img/Curtidas.png"" alt=""Curtir""></a>
                    <a href=""#""><img src=""Img/IconeComents.png"" alt=""Comentar""></a>
                </div>
                <p>1954 curtidas</p>
                <p class=""comentarios""><span class=""user"">fausto_silva</span> Esse cara é fera bixo!!!</p>
                <p class=""comentarios""><span class=""user2"">yes_baby</span>thank you</p>
                <p class=""comentarios""><span class=""user"">adriano_stark</span> Quando eu adormecer, vou sonhar com você.</p>
                <p class=""comentarios""><span class=""user2"">yes_baby</span> Yes baby!!</p>
            </div>
        </div>
    </div>
</section>
<section class=""pubs"">
    <div class=""container"">
        <div c");
            WriteLiteral(@"lass=""publicacoes"">
            <img src=""Img/MarcosJeevesSorrindo.webp"" alt=""Foto de Marcos Jeeves sorrindo"">
            <div class=""comentuser"">
                <div class=""nomeuser-localidade"">
                    <img class=""fotoperfilpub"" src=""Img/FotoPerfil.png"" alt=""Foto de perfil de Marcos Jeeves"">
                    <div class=""titulos-nomeuser"">
                        <h2>Marcoes Jeeves</h2>
                        <h3>Rio de Janeiro, Brazil</h3>
                    </div>
                </div>
                <div class=""coments"">
                    <a href=""#""><img src=""Img/Curtidas.png"" alt=""Curtir""></a>
                    <a href=""#""><img src=""Img/IconeComents.png"" alt=""Comentar""></a>
                </div>
                <p>1954 curtidas</p>
                <p class=""comentarios""><span class=""user"">fausto_silva</span> Esse cara é fera bixo!!!</p>
                <p class=""comentarios""><span class=""user2"">yes_baby</span>thank you</p>
                <p class=""comentarios""");
            WriteLiteral(@"><span class=""user"">adriano_stark</span> Quando eu adormecer, vou sonhar com você.</p>
                <p class=""comentarios""><span class=""user2"">yes_baby</span> Yes baby!!</p>
            </div>
        </div>
    </div>
</section>
<section class=""pubs"">
    <div class=""container"">
        <div class=""publicacoes"">
            <img src=""Img/MarcosJeevesComFerimentos.jpg"" alt=""Foto de Marcos Jeeves com ferimentos no rosto em um comercial do filme CyberPunk 2077"">
            <div class=""comentuser"">
                <div class=""nomeuser-localidade"">
                    <img class=""fotoperfilpub"" src=""Img/FotoPerfil.png"" alt=""Foto de perfil de Marcos Jeeves"">
                    <div class=""titulos-nomeuser"">
                        <h2>Marcoes Jeeves</h2>
                        <h3>Rio de Janeiro, Brazil</h3>
                    </div>
                </div>
                <div class=""coments"">
                    <a href=""#""><img src=""Img/Curtidas.png"" alt=""Curtir""></a>
                 ");
            WriteLiteral(@"   <a href=""#""><img src=""Img/IconeComents.png"" alt=""Comentar""></a>
                </div>
                <p>1954 curtidas</p>
                <p class=""comentarios""><span class=""user"">fausto_silva</span> Esse cara é fera bixo!!!</p>
                <p class=""comentarios""><span class=""user2"">yes_baby</span>thank you</p>
                <p class=""comentarios""><span class=""user"">adriano_stark</span> Quando eu adormecer, vou sonhar com você.</p>
                <p class=""comentarios""><span class=""user2"">yes_baby</span> Yes baby!!</p>
            </div>
        </div>
    </div>
</section>
");
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
