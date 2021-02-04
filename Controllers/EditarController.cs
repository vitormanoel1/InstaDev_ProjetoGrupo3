using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace InstaDev_ProjetoGrupo3.Controllers
{
        [Route("Editar")]
    public class EditarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}