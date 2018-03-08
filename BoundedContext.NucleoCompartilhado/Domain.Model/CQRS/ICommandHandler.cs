namespace BoundedContext.NucleoCompartilhado.Domain.Model.CQRS
{
    public interface ICommandHandler
    {
        void Execute(ICommand command);
    }
}