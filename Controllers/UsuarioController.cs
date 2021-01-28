using InstaDev_ProjetoGrupo3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_ProjetoGrupo3.Controllers
{
    [Route("Jogador")]
    public class UsuarioController : Controller
    {
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            ViewBag.Usuarios = usuarioModel.ReadAll();
            return View();
        }
        [Route("Cadastrar")]
        public IActionResult Cadastrar (IFormCollection form)
        {
            Usuario novoUsuario = new Usuario();
            novoUsuario.Email= (form["E-mail"]);
            novoUsuario.Nome= (form ["Nome Completo"]);
            novoUsuario.Nickname= ("Nome de Usuário");
            novoUsuario.Senha= ("Senha");

            usuarioModel.Create(novoUsuario);
            ViewBag.Usuarios = usuarioModel.ReadAll();

            return LocalRedirect("~/Usuario");
        }
    }
}