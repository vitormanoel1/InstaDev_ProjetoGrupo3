using System;
using System.Collections.Generic;
using System.IO;

namespace InstaDev_ProjetoGrupo3.Models
{
<<<<<<< HEAD
    public class Usuario:InstaDevBase, IUsuario
=======
    public class Usuario : InstaDevBase
>>>>>>> PaginaLogin
    {
        public string Email{get;set;}
        public string Nome { get; set; }
        public string Nickname { get; set; }
        public string Senha { get; set; }


        private const string PATH = "Database/Usuario.csv";

        public Usuario(){
            CreateFolderAndFile(PATH);
        }

        public string Prepare( Usuario u){
            return $"{u.Email};{u.Nome};{u.Nickname};{u.Senha}";
        }

        public void Create(Usuario u){
            string [] linhas = {Prepare(u)};
            File.AppendAllLines(PATH,linhas);
        }
        public void Delete(int id){
            List<string> linhas = ReadAllLinesCSV(PATH);

            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());

            RewriteCSV(PATH,linhas);

        }
        public List<Usuario> ReadAll()
        {
            List<Usuario> usuarios = new List<Usuario>();

             string[] linhas = File.ReadAllLines(PATH);

             foreach (var item in linhas)
             {
                 string [] linha = item.Split(";");

                 Usuario usuario = new Usuario();

                 usuario.Email= linha [0];
                 usuario.Nome= linha [1];
                 usuario.Nickname= linha [2];
                 usuario.Senha= linha [3];

                 usuarios.Add(usuario);
             }
             return usuarios;
        }

        public void Update(Usuario u)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);

            linhas.RemoveAll(y => y.Split(";")[0] == u.Email);

            linhas.Add(Prepare (u));

            RewriteCSV(PATH,linhas);
        }
        
    }
}