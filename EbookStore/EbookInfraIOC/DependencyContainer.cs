using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using EbookApplication.interfaces;
using EbookApplication.Services;
using EbookDomain.Interfaces;
using EbookInfraData.Repository;

namespace EbookInfraIOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer 
            services.AddScoped<IBookService, BookService>();

            // Infra.Data Layer

            services.AddScoped<IBookRepository, BookRepository>();

        }
    }
}
