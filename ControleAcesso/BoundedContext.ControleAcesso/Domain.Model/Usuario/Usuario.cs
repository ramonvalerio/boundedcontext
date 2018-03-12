using BoundedContext.NucleoCompartilhado.Domain.Model;
using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using System;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuario
{
    public class Usuario : AggregateRoot
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

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
    }
}