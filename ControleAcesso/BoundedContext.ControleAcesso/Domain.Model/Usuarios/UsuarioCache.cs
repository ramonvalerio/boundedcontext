using BoundedContext.ControleAcesso.Domain.Model.Usuarios;
using BoundedContext.NucleoCompartilhado.Infrastructure.Cache;
using System.Collections.Generic;

namespace BoundedContext.ControleAcesso.Infrastructure.Cache
{
    public class UsuarioCache : CachedRepository<Usuario>
    {
        private Dictionary<int, Usuario> _usuarios;

        public UsuarioCache()
        {
            _usuarios = new Dictionary<int, Usuario>();
            //Repository.
        }
    }
}