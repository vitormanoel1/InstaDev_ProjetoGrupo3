using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
<<<<<<< HEAD
=======
using InstaDev_ProjetoGrupo3.Models;
>>>>>>> origin/PaginaDeCadastro

namespace InstaDev_ProjetoGrupo3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
<<<<<<< HEAD
=======

>>>>>>> origin/PaginaDeCadastro
    }
}
