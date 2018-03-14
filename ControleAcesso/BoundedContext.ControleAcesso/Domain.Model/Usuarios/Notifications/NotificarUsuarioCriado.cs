using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using System;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuarios
{
    public class NotificarUsuarioCriado : IHandle<UsuarioCriado>
    {
        public void Handle(UsuarioCriado args)
        {
            Console.WriteLine($"Usuário { args.Usuario.Email } criado as { args.DataOcorreu }");
        }
    }
}