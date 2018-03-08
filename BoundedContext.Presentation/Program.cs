using BoundedContext.NucleoCompartilhado.Domain.Events;
using BoundedContext.NucleoCompartilhado.Infrastructure.IoC;
using BoundedContext.Vendas.Domain.Model.Produto;
using System;

namespace BoundedContext.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            InjectorContainer.RegisterServices();

            // 1 - Criar Produto
            var produto = new Produto(1);

            // 2 - Criar Evento
            var produtoCriado = new ProdutoCriado(produto);

            // 3 - Notificando o evento
            DomainEvents.Raise(produtoCriado);

            Console.WriteLine("Hello World!");
        }
    }
}
