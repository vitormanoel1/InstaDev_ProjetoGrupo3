using System.Collections.Generic;
using System.IO;
using InstaDev_ProjetoGrupo3.Interfaces;

namespace InstaDev_ProjetoGrupo3.Models
{
    public class Comentario : InstaDevBase, IComentarios
    {
        public int IdComentario { get; set; }
        
        public string Mensagem { get; set; }

        private const string PATH = "Database/Comentario.csv";
        public Comentario(){
            CreateFolderAndFile(PATH);
        }
        public string Prepare(Comentario c){
            return $"{c.IdComentario};{c.Mensagem}";
        }

        public void Create(Comentario c)
        {
            string [] linhas = {Prepare(c)};
            File.AppendAllLines(PATH,linhas);
        }

        public void Delete(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);

            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());

            RewriteCSV(PATH,linhas);
        }

        public List<Comentario> ReadAll()
        {
            List<Comentario> comentarios = new List<Comentario>();

             string[] linhas = File.ReadAllLines(PATH);

             foreach (var item in linhas)
             {
                 string [] linha = item.Split(";");

                 Comentario comentario = new Comentario();

                 comentario.IdComentario= int.Parse(linha [0]);
                 comentario.Mensagem= linha [1];                 

                 comentarios.Add(comentario);
             }
             return comentarios;
        }

        public void Update(Comentario c)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);

            linhas.RemoveAll(y => y.Split(";")[0] == c.IdComentario.ToString());

            linhas.Add(Prepare (c));

            RewriteCSV(PATH,linhas);
        }

        List<Usuario> IComentarios.ReadAll()
        {
            throw new System.NotImplementedException();
        }
    }
}