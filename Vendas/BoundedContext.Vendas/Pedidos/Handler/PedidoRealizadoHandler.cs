using BoundedContext.Common.Handlers;
using BoundedContext.Vendas.Domain.Model.Venda.Commands;
using BoundedContext.Vendas.Domain.Pedidos.Commands;
using Flunt.Notifications;

namespace BoundedContext.Vendas.Domain.Pedidos.Handler
{
    public class PedidoRealizadoHandler : Notifiable, IHandler<RealizarPedidoCommand>
    {
        public ICommandResult Handle(RealizarPedidoCommand command)
        {
            // Verificar se produto está em estoque

            // Gerar os ValueObjects

            // Gerar os Agregados

            // Salvar as Informações

            // Enviar E-mail de boas vindas

            // Retornar informações

            return new CommandResult(true, "");
        }
    }
}
