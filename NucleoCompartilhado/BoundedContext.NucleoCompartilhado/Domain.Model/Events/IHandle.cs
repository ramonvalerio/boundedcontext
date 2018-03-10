namespace BoundedContext.NucleoCompartilhado.Domain.Model.Events
{
    public interface IHandle<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}