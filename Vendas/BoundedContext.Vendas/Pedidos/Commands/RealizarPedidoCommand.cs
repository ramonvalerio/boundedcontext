using BoundedContext.Common.Domain.Model;
using Flunt.Notifications;
using System;

namespace BoundedContext.Vendas.Domain.Model.Venda.Commands
{
    public class RealizarPedidoCommand : Notifiable, ICommand
    {
        public int NumeroPedido { get; set; }

        public DateTime DataPedido { get; set; }

        public int IdUsuario { get; set; }

        public void Validate()
        {
            //AddNotification(new Contract()
            //    .Requires()
            //    .HasMinLen("", 3, "","")
            //    .HasMinLen("", 3, "")
            //    .HasMaxLen(40, "","")
            //    );
        }
    }
}