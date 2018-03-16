using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace BoundedContext.Vendas.Infrastructure.Service
{
    public class PedidoService
    {
        private ScriptEngine _engine;

        public PedidoService()
        {
            _engine = Python.CreateEngine();
        }
    }
}