using System;

namespace BoundedContext.NucleoCompartilhado.Domain.Events
{
    public interface IDomainEvent
    {
        DateTime DataOcorrida { get; }
    }
}