using System.Collections.Generic;
using System.IO;
using InstaDev_ProjetoGrupo3.Interfaces;
using System;

namespace InstaDev_ProjetoGrupo3.Models
{
    public class Publicacao : PublicBase , IPublicacao
    {
        public int IdPublicacao { get; set; }
        public string Imagem { get; set; }
        public string Legenda { get; set; }
        public int IdUsuario { get; set; }
        public int Likes { get; set; }
        
        private const string PATH ="Database/Publicacao.csv";

        public Publicacao()
        {
            CreateFolderAndFile(PATH);
        }

        public void Create(Publicacao A)
        {
            string[] linha = {Prepare(A)};
            File.AppendAllLines(PATH, linha);
        }

        public string Prepare(Publicacao A)
        {
            A.Likes = 0;
            return $"{A.IdPublicacao};{A.IdUsuario};{A.Imagem};{A.Legenda};{A.Likes}";
        }
        
        public void Delete(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
             
             linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
             
             ReWriteCSV(PATH, linhas);
        }

        public List<Publicacao> ReadAll()
        {
            List<Publicacao> post = new List<Publicacao>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Publicacao publicacao = new Publicacao();

                publicacao.IdPublicacao = int.Parse(linha[0]);
                publicacao.IdUsuario = 1;
                publicacao.Imagem = linha[2];
                publicacao.Legenda = linha[3];
                publicacao.Likes = int.Parse(linha[4]);
                post.Add(publicacao);
            }
            return post;
        }

        public void Update(Publicacao A)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
             
             linhas.RemoveAll(x => x.Split(";")[0] == A.IdPublicacao.ToString());

             linhas.Add(Prepare(A));

             ReWriteCSV(PATH, linhas);
        }
    }
}