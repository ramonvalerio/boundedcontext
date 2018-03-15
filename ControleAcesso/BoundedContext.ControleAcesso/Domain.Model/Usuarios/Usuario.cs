using BoundedContext.NucleoCompartilhado.Domain.Model;
using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using System;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuarios
{
    public class Usuario : AggregateRoot
    {
        public Email Email { get; set; }

        public string Senha { get; set; }

        public void Autenticar()
        {
            DomainEvents.Raise(new UsuarioAutenticado(this));
        }

        public static Usuario Criar(string email)
        {
            var usuario = new Usuario { Email = new Email(email) };

            DomainEvents.Raise(new UsuarioCriado(usuario, DateTime.Now));

            return usuario;
        }

        public bool IsValid()
        {
            if (!Email.IsValid())
                return false;

            if (string.IsNullOrWhiteSpace(Senha))
                return false;

            return true;
        }
    }
}