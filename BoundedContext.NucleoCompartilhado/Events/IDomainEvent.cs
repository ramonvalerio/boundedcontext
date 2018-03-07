using System;

namespace BoundedContext.NucleoCompartilhado.Domain.Events
{
    public interface IDomainEvent
    {
        int VersaoEvento { get; }
        DateTime DataOcorrida { get; }
    }
}