using System.Collections.Generic;
using InstaDev_ProjetoGrupo3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace InstaDev_ProjetoGrupo3.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
         [TempData]
        public string Mensagem { get; set; }
        
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Login(IFormCollection form)
        {
            // Lemos todos os arquivos do CSV
            List<string> csv = usuarioModel.ReadAllLinesCSV("Database/Usuario.csv");

            // Verificamos se as informações passadas existe na lista de string
            var logado = 
            csv.Find(
                x => 
                x.Split(";")[0] == form["Email"] && 
                x.Split(";")[1] == form["Senha"]
            );
                


            // Redirecionamos o usuário logado caso encontrado
            if(logado != null)
            {
                // salvar a informação do nome na sessão
                HttpContext.Session.SetString("_UserName", logado.Split(";")[1]);

                return LocalRedirect("~/");
            }

            Mensagem = "Dados incorretos, tente novamente...";
            return LocalRedirect("~/Logar");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("_UserName");
            return LocalRedirect("~/");
        }
    }
}