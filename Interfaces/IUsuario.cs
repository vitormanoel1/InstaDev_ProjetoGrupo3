using System.Collections.Generic;
using InstaDev_ProjetoGrupo3.Models;

namespace InstaDev_ProjetoGrupo3.Interfaces
{
    public interface IUsuario
    {
<<<<<<< HEAD
         // chamando os metodos de CRUD
         void Create(Usuario usuario);
         List<Usuario> ReadAll();
         void Update(Usuario usuario);
         void Delete(string usuario);
=======
         void Create(Usuario U);
         List<Usuario> ReadAll();
         void Update(Usuario u);
         void Delete(int id);
>>>>>>> origin/PaginaDeCadastro
    }
}