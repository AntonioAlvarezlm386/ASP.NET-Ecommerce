using BussinesLayer.Interfaces;
using BussinesLayer.Services;
using DataLayer;
using DataLayer.Interfaces;
using DataLayer.Repositorios;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace AdminPanel
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<AppDBContext>(new HierarchicalLifetimeManager());


            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IProductRepository, ProductRepository>();
            
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}