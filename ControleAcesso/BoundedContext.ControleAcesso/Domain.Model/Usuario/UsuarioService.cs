using BoundedContext.ControleAcesso.Infrastructure.Repository;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuario
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }
    }
}