using BoundedContext.ControleAcesso.Domain.Model.Usuarios;
using BoundedContext.NucleoCompartilhado.Infrastructure.IoC;
using System;

namespace BoundedContext.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            InjectorContainer.InitIoC();

            Console.WriteLine("Antes do evento!");

            // Cria o usuário e dispara um evento printando o console com os dados do usuário
            var usuario = Usuario.Criar("foo@gmail.com");

            Console.WriteLine("Depois do evento!");

            Console.ReadKey();
        }
    }
}
