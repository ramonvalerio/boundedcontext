using BoundedContext.NucleoCompartilhado.Infrastructure.IoC;

namespace BoundedContext.NucleoCompartilhado.Domain.Events
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
        }
    }
}