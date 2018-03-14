using System;

namespace BoundedContext.NucleoCompartilhado.Domain.Model.Events
{
    public interface IDomainEvent
    {
        //int VersaoEvento { get; set; }
        DateTime DataOcorreu { get; }
    }
}