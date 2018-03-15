using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using System;

namespace BoundedContext.Vendas.Domain.Model.Produtos
{
    public class ProdutoCriado : IDomainEvent
    {
        public Produto Produto { get; private set; }

        public int VersaoEvento { get; private set; }

        public DateTime DataOcorreu { get; private set; }

        public ProdutoCriado(Produto produto, DateTime dataCriada)
        {
            Produto = produto;

            VersaoEvento = produto.Id;
            DataOcorreu = dataCriada;
        }

        public ProdutoCriado(Produto produto) : this(produto, DateTime.Now)
        {

        }
    }
}