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

            //_container.Register<IDomainEvent, UsuarioAutenticado>();
        }

        public static IEnumerable<IHandle<T>> GetAllEvents<T>() where T : IDomainEvent
        {
            return _container.GetAllInstances<IHandle<T>>();
        }

        public static void RegisterServices()
        {
            //_container.Register(aggregateRoot);

            //var repositoryAssembly = typeof(SqlUserRepository).Assembly;

            //var registrations = from type in repositoryAssembly.GetExportedTypes()
            //where type.Namespace == "MyComp.MyProd.BL.SqlRepositories"
            //where type.GetInterfaces().Any()
            //select new { Service = type.GetInterfaces().Single(), Implementation = type };

            //foreach (var reg in registrations)
            //{
            //    container.Register(reg.Service, reg.Implementation, Lifestyle.Transient);
            //}
        }
    }
}