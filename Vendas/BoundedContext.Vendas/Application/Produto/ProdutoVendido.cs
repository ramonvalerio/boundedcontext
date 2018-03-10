using System;
using BoundedContext.NucleoCompartilhado.Domain.Events;

namespace BoundedContext.Vendas.Application.Produto
{
    public class ProdutoVendido : IDomainEvent
    {
        public int VersaoEvento => throw new NotImplementedException();

        public DateTime DataOcorrida => throw new NotImplementedException();
    }
}