using BoundedContext.NucleoCompartilhado.Domain.Model;

namespace BoundedContext.Vendas.Domain.Pedidos
{
    public class Pedido : AggregateRoot
    {
        public string Codigo { get; private set; }

        public string CodigoDesconto { get; private set; }

        public Pedido(string codigo, string codigoDesconto)
        {
            Codigo = codigo;
            CodigoDesconto = codigoDesconto;
        }
    }
}