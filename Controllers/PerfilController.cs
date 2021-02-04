using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace InstaDev_ProjetoGrupo3.Controllers
{
        [Route("Perfil")]
    public class PerfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}