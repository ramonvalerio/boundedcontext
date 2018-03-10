namespace BoundedContext.NucleoCompartilhado.Domain.Model.CQRS
{
    public interface ICommandDispatcher
    {
        void Execute(ICommand command);
    }
}