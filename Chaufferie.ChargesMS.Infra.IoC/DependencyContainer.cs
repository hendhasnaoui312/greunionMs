using Chaufferie.ChargeMS.Data.Repository;
using Chaufferie.ChargesMS.Domain.Interfaces;
using Chaufferie.ChargesMS.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Chaufferie.ChargesMS.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {

       
			services.AddTransient<IGenericRepository<Réunion>, GenericRepository<Réunion>>();
            services.AddTransient<IGenericRepository<Reunion_aprés_cloture>, GenericRepository<Reunion_aprés_cloture>>();;
            services.AddTransient<IGenericRepository<Reunion_avant_cloture>, GenericRepository<Reunion_avant_cloture>>();
            services.AddTransient<IGenericRepository<TypeReunion>, GenericRepository<TypeReunion>>();
            services.AddTransient<IGenericRepository<TypeReunion_sous_service>, GenericRepository<TypeReunion_sous_service>>();

        }
    }
}
