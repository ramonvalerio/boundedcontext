using System;
using BoundedContext.NucleoCompartilhado.Domain.Events;

namespace BoundedContext.Vendas.Domain.Model.Produto
{
    public class ProdutoCadastrado : IDomainEvent
    {
        public int VersaoEvento { get; }

        public DateTime DataOcorrida { get; }

        public ProdutoCadastrado(int idProduto)
        {
            VersaoEvento = idProduto;
            DataOcorrida = DateTime.Now;
        }
    }
}