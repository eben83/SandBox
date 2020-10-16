using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using OdeToFood.Data.Services;

namespace OdeToFood.Web
{
    public class ContainerConfig
    {
        public static void RegisterContainer()
        {
            //builds the container
            var builder = new ContainerBuilder();
            
            
            //registering the controllers and the in memory data
            //mvc app is the class from the behind global.asax class
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            
            //used the sql data
            builder.RegisterType<SqlRestaurantData>()
                .As<IRestaurantData>()
                .InstancePerRequest();
            builder.RegisterType<OdeToFoodDbContext>().InstancePerRequest();

            
            //builds the container to display the in memory data
            var container = builder.Build();
            
            
            //construction AutoFac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}