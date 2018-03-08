namespace BoundedContext.NucleoCompartilhado.Domain.Model.CQRS
{
    public interface IQueryDispatcher
    {
        void Execute(IQuery query);
    }
}