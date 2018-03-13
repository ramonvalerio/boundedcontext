using BoundedContext.NucleoCompartilhado.Domain.Model;
using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using System;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuarios
{
    public class Usuario : AggregateRoot
    {
        public Guid Id { get; private set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public Usuario()
        {
            Id = Guid.NewGuid();
        }

        public void Autenticar()
        {
            DomainEvents.Raise(new UsuarioAutenticado(this));
        }

        public static Usuario Criar(string email)
        {
            var usuario = new Usuario { Email = email };

            DomainEvents.Raise(new UsuarioCriado(usuario, DateTime.Now));

            return usuario;
        }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Email))
                return false;

            return true;
        }
    }
}