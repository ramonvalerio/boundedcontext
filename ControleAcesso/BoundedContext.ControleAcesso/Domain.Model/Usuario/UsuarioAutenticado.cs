using BoundedContext.NucleoCompartilhado.Domain.Model.Events;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuario
{
    public class UsuarioAutenticado : IDomainEvent
    {
        public Usuario Usuario { get; set; }
    }
}