using System;
using System.IO;
using InstaDev_ProjetoGrupo3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_ProjetoGrupo3.Controllers
{
    [Route("Publicacao")]
    public class Publicontroller : Controller
    {
        Publicacao publiModel = new Publicacao();
        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Publicacao = publiModel.ReadAll();
            return View();
        }
        

        [Route("Postar")]
        public IActionResult Postar(IFormCollection PubliForm)
        {
   
            Publicacao newpub = new Publicacao();
            newpub.IdUsuario = 1;
            newpub.Legenda = PubliForm["Legenda"];
            newpub.Likes = 0;

            
            //Inicio IdPublicacao
            Random randNum = new Random();
            randNum.Next();

            newpub.IdPublicacao = randNum.Next();
            //Fim Id Publicacao


            //INICIO
            if(PubliForm.Files.Count > 0)
            {
                var Post = PubliForm.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/Publicacoes");

                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/", folder, Post.FileName);

                using (var Stream = new FileStream(path, FileMode.Create))
                {
                    Post.CopyTo(Stream);
                }
                newpub.Imagem = Post.FileName;
            }
            else
            {
                newpub.Imagem ="padrao.png";
            }
            //FIM

            publiModel.Create(newpub);
            ViewBag.Publicacao = publiModel.ReadAll();

            return LocalRedirect("~/Publicacao/Listar");
            //Return Local Redirect("~/Publicacao");
        }
        [Route("{id}")]
        public IActionResult ExcluirPost(int id)
        {
            publiModel.Delete(id);

            ViewBag.Publicacao = publiModel.ReadAll();

            return LocalRedirect("~/Publicacao/Listar");


        }
    }
}
