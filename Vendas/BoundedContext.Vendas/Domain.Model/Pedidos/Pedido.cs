using BoundedContext.NucleoCompartilhado.Domain.Model;
using BoundedContext.Vendas.Domain.Model.Pedidos;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BoundedContext.Vendas.Domain.Model.Venda
{
    public class Pedido : AggregateRoot
    {
        public ImmutableList<Item> Itens { get; private set; }

        public Pedido()
        {
            Itens = new List<Item>().ToImmutableList();
            Itens.Add(new Item());
        }

        private void AddOther()
        {
            Itens.Add(new Item());
        }
    }
}