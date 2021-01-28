using InstaDev_ProjetoGrupo3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_ProjetoGrupo3.Controllers
{
    [Route("Usuario")]
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
            novoUsuario.Email= (form["Email"]);
            novoUsuario.Nome= (form ["Nome"]);
            novoUsuario.Nickname= (form["Nickname"]);
            novoUsuario.Senha= (form["Senha"]);

            usuarioModel.Create(novoUsuario);
            ViewBag.Usuarios = usuarioModel.ReadAll();

            return LocalRedirect("~/Usuario");
        }
    }
}