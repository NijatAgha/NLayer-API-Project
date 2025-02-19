﻿using Autofac;
using Autofac.Core;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Data.Context;
using NLayer.Data.Repositories;
using NLayer.Data.UnitOfWorks;
using NLayer.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace NLayer.API.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
           builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

           builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

           var apiAssembly = Assembly.GetExecutingAssembly();
           var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
           var serviceAssembly = Assembly.GetAssembly(typeof(ProductService));
            
           builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
