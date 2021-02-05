using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using InstaDev_ProjetoGrupo3.Models;
using Microsoft.AspNetCore.Http;

namespace InstaDev_ProjetoGrupo3.Controllers
{
    public class HomeController : Controller
    {
    
         [TempData]
        public string Mensagem { get; set; }
        
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            // ViewBag.Nickname = HttpContext.Session.GetString("Nickname");
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            // Lemos todos os arquivos do CSV
            List<string> csv = usuarioModel.ReadAllLinesCSV("Database/Usuario.csv");

            // Verificamos se as informações passadas existe na lista de string
            var logado = 
            csv.Find(
                x => 
                x.Split(";")[0] == form["Email"] && 
                x.Split(";")[3] == form["Senha"]
            );


            // Redirecionamos o usuário logado caso encontrado
            if(logado != null)
            {
                // salvar a informação do nome na sessão
                HttpContext.Session.SetString("Nickname", logado.Split(";")[1]);

                return LocalRedirect("~/Publicacao/Listar");
            }

            Mensagem = "Dados incorretos, tente novamente...";
            return LocalRedirect("~/");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Nickname");
            return LocalRedirect("~/");
        }
    }
}


    

