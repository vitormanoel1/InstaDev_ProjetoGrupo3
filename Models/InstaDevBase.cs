using System.Collections.Generic;
using System.IO;

namespace InstaDev_ProjetoGrupo3.Models
{
<<<<<<< HEAD
    public class InstaDevBase
    {
        // metodo de criar pasta e arquivo
        public void CreateFolderAndFile(string Caminho)
        {
            // DataBase/Equipe.csv
            string folder = Caminho.Split("/")[0];

            // metodo para criar pasta caso ela não exista
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            // metodo para cirar arquivo caso não exista um
            if (!File.Exists(Caminho))
            {
                File.Create(Caminho);
            }
        }

        public List<string> ReadAllLinesCSV(string Caminho)
        {
            List<string> linhas = new List<string>();

            // using -> responsavel por abrir e fechar determinado tipo de arquivo ou conexão 
            // biblioteca StreamReader -> responsavel por ler as informações do meu CSV
            using (StreamReader file = new StreamReader(Caminho))
            {
                // percorremos um arquivo lido atraves de um laço WHILE
                // vai ler todas as linhas enquanto tiver linhas para ler caso contrario se encerrará o laço
                string linha;
                while ((linha = file.ReadLine()) != null)
=======
    public abstract class InstaDevBase
    {
        public void CreateFolderAndFile(string path)
        {
            //Database/Equipe.csv
            string folder = path.Split("/")[0];

            if(!Directory.Exists(folder)){
                Directory.CreateDirectory(folder);
            }

            if(!File.Exists(path)){
                File.Create(path);
            }
        }
        public List<string> ReadAllLinesCSV(string path){
            List<string> linhas = new List<string>();

            //using -> abrir e fechar determinado tipo de arquivo ou conexão
            // StreamReader -> Ler as informações do meu csv
            using(StreamReader file = new StreamReader(path))
            {
                string linha;
                while((linha = file.ReadLine())!=null)
>>>>>>> origin/PaginaDeCadastro
                {
                    linhas.Add(linha);
                }
            }

            return linhas;
        }
<<<<<<< HEAD

        // metodo para rescrever o CSV
        public void RewriteCSV(string Caminho, List<string> linhas)
        {
            // biblioteca StreamWriter -> responsavel pela escrita de arquivos
            using (StreamWriter  saidaArquivo = new StreamWriter(Caminho))
            {
                foreach (var item in linhas)
                {
                    saidaArquivo.Write(item+ '\n');
=======
        public void RewriteCSV(string path, List<string> linhas){
            using (StreamWriter ouput = new StreamWriter(path)){
                foreach (var item in linhas)
                {
                    ouput.Write(item + '\n');
>>>>>>> origin/PaginaDeCadastro
                }
            }
        }
    }
<<<<<<< HEAD
}
=======
    }
>>>>>>> origin/PaginaDeCadastro
