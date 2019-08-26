using AtividadeTecnica.Application.Services.Interfaces;
using AtividadeTecnica.Application.ViewModels;
using AtividadeTecnica.Infra.CrossCutting.IOC;
using AtividadeTecnica.WebApi.Configurations;
using AtividadeTecnica.WebApi.Controllers;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;

namespace AtividadeTecnica.WebApi.IntegrationTests.Controllers
{
    class CarrinhoControllerTest
    {
        private CarrinhoController _carrinhoController;

        private CarrinhoViewModel carrinhoViewModelMock;
        //private OkObjectResult resultadoOkMock;
        //private ObjectResult resultadoErroMock;

        private const int STATUSCODESUCESSO = 200;

        private string calculoProdutos;

        private IServiceCollection serviceCollection;

        [SetUp]
        public void SetUp()
        {
            serviceCollection = new ServiceCollection();

            serviceCollection.AddAutoMapperSetup();

            InjectionDependencies.RegisterDependencies(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var carrinhoService = serviceProvider.GetService<ICarrinhoService>();
            _carrinhoController = new CarrinhoController(carrinhoService);

            carrinhoViewModelMock = new CarrinhoViewModel();

            calculoProdutos = "105,10";
            //resultadoOkMock = _carrinhoController.Ok(new { success = true, data = calculoProdutos });

            //resultadoErroMock = new ObjectResult($"Erro ao calcular total produtos!");
        }

        [Test]
        public void Ao_Realizar_Consumo_Calculo_Juros_Api_Sem_Informacoes_De_Calculo_Deve_Retornar_Erro()
        {
            Assert.Throws<ArgumentNullException>(
                () => _carrinhoController.CalcularTotalProdutos(null),
                   "Não deve ser realizado o cálculo do juros sem as informações predefinidas!");
        }

        [Test]
        public void Ao_Realizar_Consumo_Calculo_Juros_Api_Com_Informacao_De_Calculo_Invalida_Deve_Retornar_Mensagem_Erro()
        {
            calculaJurosViewModelMock.TempoEmMeses = -5;

            var resultado = _carrinhoController.PostCalculaJurosViewModel(calculaJurosViewModelMock);

            Assert.IsInstanceOf(typeof(ObjectResult), resultado);

            var errorResult = resultado as ObjectResult;

            Assert.AreEqual(resultadoErroMock.Value.ToString(), errorResult.Value.ToString(), $"Não deve ser calculado juros quando o tempo em meses for negativo!");
        }

        [Test]
        public void Ao_Realizar_Consumo_Calculo_Juros_Api_Deve_Retornar_Valor_Calculado_Com_Juros()
        {
            var resultado = _carrinhoController.PostCalculaJurosViewModel(calculaJurosViewModelMock);

            Assert.IsInstanceOf(typeof(OkObjectResult), resultado);

            var okResult = resultado as OkObjectResult;

            Assert.IsTrue(okResult.StatusCode == STATUSCODESUCESSO, "O Serviço deve ser consumido com sucesso!");

            Assert.AreEqual(resultadoOkMock.Value.ToString(), okResult.Value.ToString(), $"O valor com juros deve ser R$ { calculoJuros }!");
        }

        [TearDown]
        public void TearDown()
        {
            AutoMapperSetup.RemoveAutoMapperSetup(serviceCollection);
        }
    }
}
