namespace BoundedContext.ControleAcesso.Application.DTOs
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}