using System.Collections.Generic;
using InstaDev_ProjetoGrupo3.Models;

namespace InstaDev_ProjetoGrupo3.Interfaces
{
    public interface IComentarios
    {
          void Create(Comentario C);
         List<Usuario> ReadAll();
         void Update(Comentario c);
         void Delete(int id);
    }
}