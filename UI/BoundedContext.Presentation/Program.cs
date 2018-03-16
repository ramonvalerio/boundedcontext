using BoundedContext.ControleAcesso.Domain.Model.Usuarios;
using BoundedContext.NucleoCompartilhado.Domain.Model;
using BoundedContext.NucleoCompartilhado.Infrastructure.IoC;
using BoundedContext.Vendas.Domain.Model.Produtos;
using BoundedContext.Vendas.Domain.Pedidos;
using System;

namespace BoundedContext.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            InjectorContainer.InitIoC();

            var pedido = new Pedido("123", "");
            var produto = new Produto();

            pedido.AddMessage($"Erro no pedido {pedido.Id}.");
            produto.AddMessage($"Erro no produto {produto.Id}.");

            Console.WriteLine("Antes do evento!");

            // Cria o usuário e dispara um evento printando o console com os dados do usuário
            var usuario = Usuario.Criar("foo@gmail.com");

            Console.WriteLine("Depois do evento!");

            foreach (var item in pedido.Messages())
                Console.WriteLine(item);

            foreach (var item in produto.Messages())
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
