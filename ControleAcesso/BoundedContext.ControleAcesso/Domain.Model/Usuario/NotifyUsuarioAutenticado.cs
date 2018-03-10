using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using System;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuario
{
    public class NotifyUsuarioAutenticado : IHandle<UsuarioAutenticado>
    {
        public void Handle(UsuarioAutenticado args)
        {
            Console.WriteLine($"Usuário Autenticado em { args.DataOcorrida }.");
        }
    }
}