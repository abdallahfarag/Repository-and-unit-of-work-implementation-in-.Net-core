using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SQLAccess.IRepositories;
using SQLAccess.IUnitOfWork;
using SQLProvider.ECommerceContext;
using SQLProvider.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLProvider.UnitOfWork
{
    public static class RepositoryAndUnitOfWorkInjector
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddTransient<IProductImages, ProductImages>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<ECommerceDbContext>(opt => opt
                .UseSqlServer("Server=.;Database=ECommerceFeatures;Trusted_Connection=True;"));
            return services;
        }
    }
}
