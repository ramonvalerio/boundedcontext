using BoundedContext.NucleoCompartilhado.Domain.Model;
using BoundedContext.NucleoCompartilhado.Infrastructure.Repository;

namespace BoundedContext.NucleoCompartilhado.Infrastructure.Cache
{
    public abstract class CachedRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        protected Repository<TAggregateRoot> Repository;
    }
}