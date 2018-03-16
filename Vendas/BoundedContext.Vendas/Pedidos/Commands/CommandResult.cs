using BoundedContext.Common.Handlers;

namespace BoundedContext.Vendas.Domain.Pedidos.Commands
{
    public class CommandResult : ICommandResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public CommandResult(bool sucess, string message)
        {

        }
    }
}