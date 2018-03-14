using BoundedContext.NucleoCompartilhado.Domain.Model.Events;
using BoundedContext.NucleoCompartilhado.Infrastructure.Repository;
using StructureMap;
using System.Collections.Generic;

namespace BoundedContext.NucleoCompartilhado.Infrastructure.IoC
{
    public static class InjectorContainer
    {
        private static Container _container;

        static InjectorContainer()
        {
            _container = new Container();
        }

        public static void InitIoC()
        {
            _container.Configure(config =>
            {
                config.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    //scan.IncludeNamespaceContainingType<NotificarUsuarioCriado> // especificar namespace contendo um tipo localizado
                    scan.ConnectImplementationsToTypesClosing(typeof(IHandle<>));
                    scan.IncludeNamespace("DomainEventsConsole.Repositories");
                    scan.ConnectImplementationsToTypesClosing(typeof(Repository<>));
                });
            });
        }

        public static IEnumerable<IHandle<T>> GetAllEvents<T>() where T : IDomainEvent
        {
            return _container.GetAllInstances<IHandle<T>>();
        }

        public static void RegisterHandle<T>(T handle)
        {
            //_container.Configure(x => x.AddRegistry<handle>());
        }
    }
}