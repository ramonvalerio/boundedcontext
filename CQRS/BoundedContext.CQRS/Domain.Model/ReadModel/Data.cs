using BoundedContext.NucleoCompartilhado.Domain.Model;
using System.Collections.Generic;

namespace BoundedContext.CQRS.Domain.Model.ReadModel
{
    public class Data<T> : ValueObject
    {
        public Dictionary<string, List<T>> Datas { get; private set; }

        public void Add(string key, List<T> list)
        {
            Datas.Add(key, list);
        }
    }
}