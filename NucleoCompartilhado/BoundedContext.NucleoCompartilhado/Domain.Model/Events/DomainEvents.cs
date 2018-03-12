using StructureMap;
using System;
using System.Collections.Generic;

namespace BoundedContext.NucleoCompartilhado.Domain.Model.Events
{
    public static class DomainEvents
    {
        [ThreadStatic]
        private static List<Delegate> actions;
        public static IContainer Container { get; set; }

        static DomainEvents()
        {
            Container = new Container();
        }

        public static void Register<T>(Action<T> callback) where T : IDomainEvent
        {
            if (actions == null)
                actions = new List<Delegate>();

            actions.Add(callback);
        }

        public static void ClearCallbacks()
        {
            actions = null;
        }

        public static void Raise<T>(T evento) where T : IDomainEvent
        {
            foreach (var handler in Container.GetAllInstances<IHandle<T>>())
                handler.Handle(evento);

            if (actions == null)
                return;

            foreach (var action in actions)
            {
                if (action is Action<T>)
                {
                    ((Action<T>)action)(evento);
                }
            }
        }
    }
}