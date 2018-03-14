using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using System;

namespace BoundedContext.Estoque.Domain.Model.Produto
{
    public class ProdutoQuantidadeAtualizada : IDomainEvent
    {
        public DateTime DataOcorreu { get; private set; }

        public ProdutoQuantidadeAtualizada()
        {
            DataOcorreu = new DateTime();
        }
    }
}