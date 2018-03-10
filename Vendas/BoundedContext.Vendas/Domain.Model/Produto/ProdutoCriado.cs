using System;
using BoundedContext.NucleoCompartilhado.Domain.Events;

namespace BoundedContext.Vendas.Domain.Model.Produto
{
    public class ProdutoCriado : IDomainEvent
    {
        public Produto Produto { get; private set; }

        public int VersaoEvento { get; private set; }
        public DateTime DataOcorrida { get; private set; }

        public ProdutoCriado(Produto produto, DateTime dataCriada)
        {
            Produto = produto;

            VersaoEvento = produto.Id;
            DataOcorrida = dataCriada;
        }

        public ProdutoCriado(Produto produto) : this(produto, DateTime.Now)
        {

        }
    }
}