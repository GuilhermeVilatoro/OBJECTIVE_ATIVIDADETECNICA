using AtividadeTecnica.Application.Services;
using AtividadeTecnica.Application.Services.Interfaces;
using AtividadeTecnica.Domain.Business.Feliz;
using AtividadeTecnica.Domain.Business.Interfaces.Feliz;
using AtividadeTecnica.Domain.Business.Interfaces.Multiplos;
using AtividadeTecnica.Domain.Business.Interfaces.Multiplos.Calculos;
using AtividadeTecnica.Domain.Business.Interfaces.PalavrasEmNumeros;
using AtividadeTecnica.Domain.Business.Interfaces.Primo;
using AtividadeTecnica.Domain.Business.Interfaces.ProdutosCarrinho;
using AtividadeTecnica.Domain.Business.Multiplos;
using AtividadeTecnica.Domain.Business.Multiplos.Calculos;
using AtividadeTecnica.Domain.Business.PalavrasEmNumeros;
using AtividadeTecnica.Domain.Business.Primo;
using AtividadeTecnica.Domain.Business.ProdutosCarrinho;
using Microsoft.Extensions.DependencyInjection;

namespace AtividadeTecnica.Infra.CrossCutting.IOC
{
    public class InjectionDependencies
    {
        /// <summary>
        /// Responsável por realizar o registro das dependências.
        /// </summary>
        /// <param name="dependencies">Lista a qual será adicionada as dependências</param>
        public static void RegisterDependencies(IServiceCollection dependencies)
        {
            #region Services
            dependencies.AddScoped<ICarrinhoService, CarrinhoService>();
            #endregion

            #region Business     
            dependencies.AddScoped<ICalculoMultiplosTresECincoBusiness, CalculoMultiplosTresECincoBusiness>();
            dependencies.AddScoped<ICalculoMultiplosTresOuCincoBusiness, CalculoMultiplosTresOuCincoBusiness>();
            dependencies.AddScoped<ICalculoMultiplosTresOuCincoESeteBusiness, CalculoMultiplosTresOuCincoESeteBusiness>();
            dependencies.AddScoped<ICalculoMultiplosFactoryBusiness, CalculoMultiplosFactoryBusiness>();           
            dependencies.AddScoped<ICalculoPalavrasEmNumerosBusiness, CalculoPalavrasEmNumerosBusiness>();
            dependencies.AddScoped<ICalculoProdutosCarrinhoBusiness, CalculoProdutosCarrinhoBusiness>();
            dependencies.AddScoped<IVerificacaoMultiploTresECincoBusiness, VerificacaoMultiploTresECincoBusiness>();
            dependencies.AddScoped<IVerificacaoMultiploTresOuCincoBusiness, VerificacaoMultiploTresOuCincoBusiness>();
            dependencies.AddScoped<IVerificacaoMultiploTresOuCincoESeteBusiness, VerificacaoMultiploTresOuCincoESeteBusiness>();
            dependencies.AddScoped<IVerificacaoNumeroFelizBusiness, VerificacaoNumeroFelizBusiness>();
            dependencies.AddScoped<IVerificacaoNumeroPrimoBusiness, VerificacaoNumeroPrimoBusiness>();
            #endregion region
        }
    }
}