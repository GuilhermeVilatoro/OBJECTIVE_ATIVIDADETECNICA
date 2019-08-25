using AtividadeTecnica.Infra.CrossCutting.IOC;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AtividadeTecnica.ConsoleApp.Configurations
{
    public static class ConfiguracaoInjecaoDependencias
    {
        /// <summary>
        /// Responsável por construir as injeções de dependência para realizar os processos.
        /// </summary>
        /// <returns>Retorna as injeções de dependência</returns>
        public static IServiceProvider Configurar()
        {
            IServiceCollection services = new ServiceCollection();
            InjectionDependencies.RegisterDependencies(services);
            return services.BuildServiceProvider();
        }
    }
}