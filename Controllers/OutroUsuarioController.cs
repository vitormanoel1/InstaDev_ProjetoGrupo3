using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace InstaDev_ProjetoGrupo3.Controllers
{
        [Route("outroUsuario")]
    public class OutroUsuarioController : Controller
    {
             
        public IActionResult Index()
        {
            return View();
        }
    }
}