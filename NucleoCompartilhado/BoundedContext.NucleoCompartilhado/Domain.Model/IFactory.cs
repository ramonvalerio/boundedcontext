using System.Collections.Generic;

namespace BoundedContext.NucleoCompartilhado.Domain.Model
{
    public interface IFactory<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        TAggregateRoot Rebuild(TAggregateRoot aggregateRoot);

        List<TAggregateRoot> RebuildAll(List<TAggregateRoot> aggregatesRoot);
    }
}