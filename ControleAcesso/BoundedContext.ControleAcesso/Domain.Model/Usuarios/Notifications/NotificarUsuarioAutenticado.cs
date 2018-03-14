using BoundedContext.NucleoCompartilhado.Domain.Model.Events;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuarios
{
    public class NotificarUsuarioAutenticado : IHandle<UsuarioAutenticado>
    {
        public void Handle(UsuarioAutenticado args)
        {
            //Console.WriteLine($"Usuário Autenticado em { args.DataOcorrida }.");
        }
    }
}