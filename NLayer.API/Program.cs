using Autofac;
using Autofac.Extensions.DependencyInjection;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLayer.API.Filters;
using NLayer.API.Middlewares;
using NLayer.API.Modules;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Data.Context;
using NLayer.Data.Repositories;
using NLayer.Data.UnitOfWorks;
using NLayer.Service.Mappings.Products;
using NLayer.Service.Services;
using NLayer.Service.Validations;
using System.Diagnostics;
using System.Reflection;

namespace NLayer.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers(options => options.Filters.Add(new ValidateFilterAttribute()))
                .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ProductDtoValidator>());

            builder.Services.Configure<ApiBehaviorOptions>(options =>
            { 
                options.SuppressModelStateInvalidFilter = true;
            });


            builder.Services.AddSwaggerGen();
            builder.Services.AddMemoryCache();

            builder.Services.AddScoped(typeof(NotFoundFilter<>));
            builder.Services.AddAutoMapper(typeof(ProductProfile));

            builder.Services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
                    {
                        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
                    });
            });

            // AutoFac

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

            builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));

            
                

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseCustomException();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapControllers();

            app.Run();
        }
    }
}
