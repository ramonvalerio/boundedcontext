using BoundedContext.NucleoCompartilhado.Domain.Model;
using System.Collections.Generic;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuarios
{
    public class UsuarioFactory : IFactory<Usuario>
    {
        public Usuario Rebuild(Usuario aggregateRoot)
        {
            aggregateRoot.Email = "foo@gmail.com";
            return aggregateRoot;
        }

        public List<Usuario> RebuildAll(List<Usuario> aggregatesRoot)
        {
            for (int i = 0; i < aggregatesRoot.Count; i++)
                aggregatesRoot[i].Email = $"foo{i}@gmail.com";

            return aggregatesRoot;
        }
    }
}