using System;
using System.Collections.Generic;
using System.IO;

namespace InstaDev_ProjetoGrupo3.Models
{
    public class Usuario : InstaDevBase
    {
        // atributos
        public string Email { get; set; }
        public string Senha { get; set; }
        
        private const string PATH = "DataBase/Usuario.csv";

        public Usuario()
        {
            CreateFolderAndFile(PATH);
        }

        public string Preparar(Usuario usuario)
        {
            return $"{usuario.Email};{usuario.Senha}";
        }

        public void Create(Usuario usuario)
        {
            string[] linhas = { Preparar(usuario) };
            File.AppendAllLines(PATH, linhas);
        }

        public void Delete(string Email)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == Email);
            RewriteCSV(PATH, linhas);
        }

        public List<Usuario> ReadAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Usuario usuario = new Usuario();

                usuario.Email = linha[0];
                usuario.Senha = linha[1];

                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public void Update(Usuario usuario)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);

            linhas.RemoveAll(x => x.Split(":")[0] == usuario.Email);

            linhas.Add( Preparar(usuario));

            RewriteCSV(PATH, linhas);        
        }
    }
}