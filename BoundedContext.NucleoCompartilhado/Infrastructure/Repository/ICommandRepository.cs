using BoundedContext.NucleoCompartilhado.Domain.Model;

namespace BoundedContext.NucleoCompartilhado.Infrastructure.Repository
{
    public interface ICommandRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        void Insert(TAggregateRoot aggregateRoot);

        void Delete(TAggregateRoot aggregateRoot);

        void Update(TAggregateRoot aggregateRoot);
    }
}