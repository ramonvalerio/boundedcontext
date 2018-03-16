using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using System;

namespace BoundedContext.Vendas.Application.Produto
{
    public class ProdutoVendido : IDomainEvent
    {
        public int VersaoEvento => throw new NotImplementedException();

        public DateTime DataOcorreu => throw new NotImplementedException();
    }
}