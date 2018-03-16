using System;

namespace BoundedContext.NucleoCompartilhado.Domain.Model
{
    public abstract class AggregateRoot
    {
        public Guid Id { get; private set; }

        public AggregateRoot()
        {
            Id = Guid.NewGuid();
        }
    }
}