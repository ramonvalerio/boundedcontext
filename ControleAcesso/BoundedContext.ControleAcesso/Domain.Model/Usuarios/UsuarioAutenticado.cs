using System;
using BoundedContext.NucleoCompartilhado.Domain.Model.Events;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuarios
{
    public class UsuarioAutenticado : IDomainEvent
    {
        public Usuario Usuario { get; private set; }

        public DateTime DataOcorreu { get; }

        public UsuarioAutenticado(Usuario usuario)
        {
            Usuario = usuario;
            DataOcorreu = DateTime.Now;
        }
    }
}