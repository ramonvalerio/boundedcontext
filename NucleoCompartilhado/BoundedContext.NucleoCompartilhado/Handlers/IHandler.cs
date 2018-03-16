using BoundedContext.Common.Domain.Model;

namespace BoundedContext.Common.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}