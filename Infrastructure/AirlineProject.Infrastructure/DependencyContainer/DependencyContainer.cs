using AirlineProject.Application.Interfaces.Repositories;
using AirlineProject.Infrastructure.Context;
using AirlineProject.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Infrastructure.DependencyContainer
{
    public static class DependencyContainer
    {
        public static void AddInsrastructureServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddScoped<ICampaingRepository, CampaingRepository>();
            services.AddScoped<IInformationRepository, InformationRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();

            services.AddDbContext<AirlineContext>(options => options.UseSqlServer(configuration.GetConnectionString("mssql")));
        }
    }
}
