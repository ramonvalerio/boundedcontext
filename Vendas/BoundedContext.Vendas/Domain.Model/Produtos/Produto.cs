using BoundedContext.NucleoCompartilhado.Domain.Model;

namespace BoundedContext.Vendas.Domain.Model.Produtos
{
    public class Produto : AggregateRoot
    {
        public int Id { get; private set; }

        public Produto(int id)
        {
            Id = id;
        }
    }
}