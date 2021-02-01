using System.Collections.Generic;
using InstaDev_ProjetoGrupo3.Models;

namespace InstaDev_ProjetoGrupo3.Interfaces
{
    public interface IUsuario
    {
         // chamando os metodos de CRUD
         void Create(Usuario usuario);
         List<Usuario> ReadAll();
         void Update(Usuario usuario);
         void Delete(string usuario);
    }
}