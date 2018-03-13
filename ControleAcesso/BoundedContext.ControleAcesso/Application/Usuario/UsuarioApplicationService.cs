using BoundedContext.ControleAcesso.Domain.Model.Usuarios;
using BoundedContext.ControleAcesso.Infrastructure.Services;

namespace BoundedContext.ControleAcesso.Application.Usuarios
{
    public class UsuarioApplicationService
    {
        private readonly UsuarioService _usuarioService;
        private readonly CriptografiaService _criptografiaService;

        public UsuarioApplicationService()
        {
            _usuarioService = new UsuarioService();
            _criptografiaService = new CriptografiaService();
        }

        public void CadastrarUsuario(string email, string senha)
        {
            var usuarioFactory = new UsuarioFactory();

            var usuario = usuarioFactory.Rebuild(new Usuario { Email = email, Senha = _criptografiaService.GetMD5Hash(senha) });

            _usuarioService.Cadastrar(usuario);
        }
    }
}