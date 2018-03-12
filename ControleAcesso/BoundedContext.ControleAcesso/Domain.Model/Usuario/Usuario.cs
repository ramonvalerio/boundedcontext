using BoundedContext.NucleoCompartilhado.Domain.Model;
using BoundedContext.NucleoCompartilhado.Domain.Model.Events;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuario
{
    public class Usuario : AggregateRoot
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public void Autenticar()
        {
            DomainEvents.Raise(new UsuarioAutenticado() { Usuario = this });
        }
    }
}