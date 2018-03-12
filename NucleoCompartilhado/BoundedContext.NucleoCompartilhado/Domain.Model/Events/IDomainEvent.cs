using System;

namespace BoundedContext.NucleoCompartilhado.Domain.Model.Events
{
    public interface IDomainEvent
    {
        DateTime DataOcorreu { get; }
    }
}