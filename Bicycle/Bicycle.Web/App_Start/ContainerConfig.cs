using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Bicycle.Data.Services;

namespace Bicycle.Web
{
    public class ContainerConfig
    {
        public static void RegisterContainer()
        {
            var builder = new ContainerBuilder();

            // mvc App is from the global.asax.cs file
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryBikeData>()
                .As<IBikeData>()
                .SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}