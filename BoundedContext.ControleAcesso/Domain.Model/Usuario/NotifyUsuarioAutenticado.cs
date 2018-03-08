using BoundedContext.ControleAcesso.Domain.Events;
using BoundedContext.NucleoCompartilhado.Domain.Events;
using System;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuario
{
    public class NotifyUsuarioAutenticado : IHandle<UsuarioAutenticado>
    {
        public void Handle(UsuarioAutenticado args)
        {
            Console.WriteLine("Usuário Autenticado.");
        }
    }
}