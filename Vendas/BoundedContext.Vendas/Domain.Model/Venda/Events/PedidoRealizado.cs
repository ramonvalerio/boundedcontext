using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using System;

namespace BoundedContext.Vendas.Domain.Events
{
    public class PedidoRealizado : IDomainEvent
    {
        public int IdCliente { get; }

        public int IdObjeto { get; }

        public DateTime DataEntregaPrevista { get; }

        public int VersaoEvento => throw new NotImplementedException();

        public DateTime DataOcorreu => throw new NotImplementedException();

        public PedidoRealizado(int idCliente, int idObjeto, DateTime dataEntregaPrevista)
        {
            IdCliente = idCliente;
            IdObjeto = idObjeto;
            DataEntregaPrevista = dataEntregaPrevista;
        }
    }
}