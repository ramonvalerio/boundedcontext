using BoundedContext.NucleoCompartilhado.Domain.Model;

namespace BoundedContext.Vendas.Domain.Model.Pedidos
{
    public class Item : ValueObject
    {
        public int Quantidade { get; set; }

        public int IdProduto { get; private set; }

        public decimal Valor { get; private set; }

        /// <summary>
        /// Permite adicionar até 10 unidades
        /// </summary>
        public void AddQuantidade()
        {
            if (Quantidade == 10)
                return;

            Quantidade++;
            Valor = CalcularValor(Valor, Quantidade);
        }

        public void RemoveQuantidade()
        {
            if (Quantidade == 0)
                return;

            Quantidade--;
            Valor = CalcularValor(Valor, Quantidade);
        }

        private decimal CalcularValor(decimal valor, int quantidade)
        {
            return valor * quantidade;
        }
    }
}
