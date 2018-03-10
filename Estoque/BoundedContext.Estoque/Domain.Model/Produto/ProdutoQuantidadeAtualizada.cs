using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using System;

namespace BoundedContext.Estoque.Domain.Model.Produto
{
    public class ProdutoQuantidadeAtualizada : IDomainEvent
    {
        public DateTime DataOcorrida { get; private set; }

        public ProdutoQuantidadeAtualizada()
        {
            DataOcorrida = new DateTime();
        }
    }
}