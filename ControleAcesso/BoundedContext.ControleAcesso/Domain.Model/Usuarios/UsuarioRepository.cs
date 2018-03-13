using BoundedContext.NucleoCompartilhado.Infrastructure.Repository;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuarios
{
    public class UsuarioRepository : Repository<Usuario>, ICommandRepository<Usuario>
    {
        public UsuarioRepository()
        {

        }

        public void Insert(Usuario aggregateRoot)
        {
            var sql = $"INSERT INTO USUARIO(ID, EMAIL, SENHA) VALUES({aggregateRoot.Id},{aggregateRoot.Email},{aggregateRoot.Senha})";
        }

        public void Delete(Usuario aggregateRoot)
        {
            var sql = $"DELETE FROM USUARIO WHERE {aggregateRoot.Id}";
        }

        public void Update(Usuario aggregateRoot)
        {
            var sql = $"UPDATE USUARIO SET ID = {aggregateRoot.Id}";
        }
    }
}