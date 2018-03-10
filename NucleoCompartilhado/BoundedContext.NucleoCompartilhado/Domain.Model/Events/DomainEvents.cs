using BoundedContext.NucleoCompartilhado.Infrastructure.IoC;

namespace BoundedContext.NucleoCompartilhado.Domain.Model.Events
{
    public static class DomainEvents
    {
        public static void Raise<T>(T evento) where T : IDomainEvent
        {
            var handles = InjectorContainer.GetAllEvents<T>();

            foreach (var handle in handles)
            {
                handle.Handle(evento);
            }

            //var registry = ConfiguracaoRegistry.RegistryConfigurado;
            //var enderecadoresDeEvento = registry.ResolverTodas<IEnderecadorDeEvento<T>>();

            //foreach (var enderecadorDeEvento in enderecadoresDeEvento)
            //{
            //    enderecadorDeEvento.EnderecarEvento(evento);
            //}
        }
    }
}