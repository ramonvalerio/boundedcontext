using BoundedContext.ControleAcesso.Domain.Model.Usuario;
using BoundedContext.NucleoCompartilhado.Domain.Events;
using System;

namespace BoundedContext.ControleAcesso.Domain.Events
{
    public class UsuarioAutenticado : IDomainEvent
    {
        public IdUsuario IdUsuario { get; set; }

        public DateTime DataOcorrida { get; }

        public UsuarioAutenticado(IdUsuario idUsuario, DateTime dataLoginEfetuado)
        {
            IdUsuario = idUsuario;
            DataOcorrida = dataLoginEfetuado;
        }
    }
}