using BoundedContext.NucleoCompartilhado.Domain.Model;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuario
{
    public class Usuario : AggregateRoot
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}