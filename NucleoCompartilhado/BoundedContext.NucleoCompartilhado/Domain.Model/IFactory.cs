using System.Collections.Generic;

namespace BoundedContext.NucleoCompartilhado.Domain.Model
{
    public interface IFactory<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        T Rebuild<T>(T aggregateRoot);

        List<T> RebuildAll<T>(List<T> aggregateRoot);
    }
}