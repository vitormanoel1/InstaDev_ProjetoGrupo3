using System.Collections.Generic;
using InstaDev_ProjetoGrupo3.Models;

namespace InstaDev_ProjetoGrupo3.Interfaces
{
    public interface IUsuario
    {
         void Create(Usuario U);
         List<Usuario> ReadAll();
         void Update(Usuario u);
         void Delete(int id);
    }
}