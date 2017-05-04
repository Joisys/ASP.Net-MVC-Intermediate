using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Jo2me.Data;
using Jo2me.Infrastructure;
using Jo2me.Infrastructure.Repository;
using Jo2me.Interface.Infrastructure;
using Jo2me.Interface.Repository;
using Jo2me.Interface.Service;
using Jo2me.Model;
using Jo2me.Service;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace Jo2me.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<DbContext, StageDbContext>(new PerThreadLifetimeManager());
            container.RegisterType<IDatabaseFactory, DatabaseFactory>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            container.RegisterType<ILocationService, LocationService>();
            container.RegisterType<IStageService, StageService>();

            container.RegisterType<IStageRepository, StageRepository>();
            container.RegisterType<ILocationRepository, LocationRepository>();

            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new InjectionConstructor(typeof(StageDbContext)));

            var resolver = new UnityDependencyResolver(container);
            DependencyResolver.SetResolver(resolver);

        }
    }
}