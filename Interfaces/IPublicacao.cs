using System.Collections.Generic;
using InstaDev_ProjetoGrupo3.Models;

namespace InstaDev_ProjetoGrupo3.Interfaces
{
    public interface IPublicacao
    {
        int IdPublicacao { get; set; }

        //Criar
        void Create(Publicacao A);

         //Ler e Listar
         List<Publicacao> ReadAll();

         //Atualizar
         void Update(Publicacao A);

         //Delete
         void Delete(int Id);
    }
}