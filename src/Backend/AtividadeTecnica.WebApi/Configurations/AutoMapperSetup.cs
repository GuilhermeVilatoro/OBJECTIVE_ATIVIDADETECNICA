using AtividadeTecnica.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AtividadeTecnica.WebApi.Configurations
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));            
            
            AutoMapperConfig.RegisterMappings();
        }

        public static void RemoveAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            AutoMapperConfig.ResetMappings();
        }
    }
}