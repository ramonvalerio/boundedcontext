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

            // Criar Evento
            var produtoCadastrado = new ProdutoCadastrado(1);

            // Realizando o evento
            DomainEvents.Raise(produtoCadastrado); // Evento

            Console.WriteLine("Hello World!");
        }
    }
}
