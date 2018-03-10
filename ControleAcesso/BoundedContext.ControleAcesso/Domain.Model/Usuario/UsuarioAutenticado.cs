using BoundedContext.NucleoCompartilhado.Domain.Events;
using System;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuario
{
    public class UsuarioAutenticado : IDomainEvent
    {
        public Usuario Usuario { get; set; }

        public DateTime DataOcorrida { get; }

        public UsuarioAutenticado(Usuario usuario, DateTime dataLoginEfetuado)
        {
            Usuario = usuario;
            DataOcorrida = dataLoginEfetuado;
        }
    }
}