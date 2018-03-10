namespace BoundedContext.NucleoCompartilhado.Domain.Events
{
    public interface IHandle<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}