using System;

namespace BoundedContext.NucleoCompartilhado.Domain.Model
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}