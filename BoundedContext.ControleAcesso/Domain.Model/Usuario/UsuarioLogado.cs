using BoundedContext.NucleoCompartilhado.Domain.Events;
using System;

namespace BoundedContext.ControleAcesso.Domain.Events
{
    public class UsuarioLogado : IDomainEvent
    {
        public int IdUsuario { get; set; }

        public int VersaoEvento { get; }

        public DateTime DataOcorrida { get; }

        public UsuarioLogado(int idUsuario, DateTime dataLoginEfetuado)
        {
            IdUsuario = idUsuario;
            DataOcorrida = dataLoginEfetuado;
        }
    }
}