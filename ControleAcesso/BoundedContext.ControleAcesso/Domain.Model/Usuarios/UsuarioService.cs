namespace BoundedContext.ControleAcesso.Domain.Model.Usuarios
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public void Cadastrar(Usuario usuario)
        {
            if (usuario.IsValid())
            {
                
            }
        }
    }
}