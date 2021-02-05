using System;
using System.IO;
using InstaDev_ProjetoGrupo3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace InstaDev_ProjetoGrupo3.Controllers
{
        [Route("Editar")]
    public class EditarController : Controller
    {

        Editar editar = new Editar();

        public IActionResult Index()
        {
            return View();
        }
        // Upload Inicio

            [Route("Editar")]
        public IActionResult Cadastrar(IFormCollection form)
        {            
            Editar novaEditar = new Editar();
            novaEditar.IdEditar = Int32.Parse( form["IdEditar"] );
            novaEditar.Nome = form["Nome"];

            if(form.Files.Count > 0)
            {
                // Upload Início
                var file    = form.Files[0];
                var folder  = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Editar");

                if(!Directory.Exists(folder)){
                    Directory.CreateDirectory(folder);
                }
                
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))  
                {  
                    file.CopyTo(stream);  
                }
                novaEditar.Imagem   = file.FileName;                
            }
            else
            {
                novaEditar.Imagem   = "padrao.png";
            }
            // Upload Final



            ViewBag.Editar = editar.Model.ReadAll();
            return LocalRedirect("~/Editar");
        }
    }
}