using BoundedContext.ControleAcesso.Domain.Model.Usuario;
using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using Xunit;

namespace BoundedContext.ControleAcesso.Teste.Domain.Model
{
    public class UsuarioTest
    {
        [Fact]
        public void VerificarSeOUsuarioFoiAutenticado()
        {
            var usuario = new Usuario();
            usuario.Email = "foo@gmail.com";

            var emailNotificado = "";

            DomainEvents.Register<UsuarioAutenticado>(x => emailNotificado = x.Usuario.Email);

        }
    }
}