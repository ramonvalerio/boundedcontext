using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using System.Collections.Generic;

namespace BoundedContext.NucleoCompartilhado.Infrastructure.IoC
{
    public static class InjectorContainer
    {
        private static SimpleInjector.Container _container;

        static InjectorContainer()
        {
            _container = new SimpleInjector.Container();
        }

        public static IEnumerable<IHandle<T>> GetAllEvents<T>() where T : IDomainEvent
        {
            return _container.GetAllInstances<IHandle<T>>();
        }

        public static void RegisterServices()
        {
            //_container.Register(aggregateRoot);

            //_container.
        }
    }
}