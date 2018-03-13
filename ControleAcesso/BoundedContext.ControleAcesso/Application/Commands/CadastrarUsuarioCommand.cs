namespace BoundedContext.ControleAcesso.Application.Commands
{
    public class CadastrarUsuarioCommand
    {
        public string Email { get; set; }

        public string Senha { get; set; }

        public CadastrarUsuarioCommand(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}
