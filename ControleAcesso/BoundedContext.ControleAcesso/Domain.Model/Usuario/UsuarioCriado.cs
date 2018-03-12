using System;
using BoundedContext.NucleoCompartilhado.Domain.Model.Events;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuario
{
    public class UsuarioCriado : IDomainEvent
    {
        public Usuario Usuario { get; private set; }
        public DateTime DataOcorreu { get; private set; }

        public UsuarioCriado(Usuario usuario, DateTime dataOcorreu)
        {
            Usuario = usuario;
            DataOcorreu = dataOcorreu;
        }
    }
}