using BoundedContext.ControleAcesso.Domain.Model.Usuario;
using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using BoundedContext.NucleoCompartilhado.Infrastructure.IoC;
using System;

namespace BoundedContext.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            InjectorContainer.RegisterServices();

            // 1 - Criar Usuário
            var usuario = new Usuario { Id = 1, Email = "ramonvalerios@gmail.com", Senha = "123456" };

            // 2 - Criar Evento
            var produtoCriado = new UsuarioAutenticado(usuario, DateTime.Now);

            // 3 - Notificando o evento
            DomainEvents.Raise(produtoCriado);

            Console.WriteLine("Hello World!");
        }
    }
}
