using AtividadeTecnica.Domain.Business.Multiplos;
using AtividadeTecnica.Domain.Business.Multiplos.Calculos;
using AtividadeTecnica.Domain.Exceptions;
using NUnit.Framework;

namespace AtividadeTecnica.Domain.UnitTests.Multiplos.Calculos
{
    public sealed class CalculoMultiplosTresOuCincoESeteBusinessTest 
    {
        private CalculoMultiplosTresOuCincoESeteBusiness calculoMultiplosTresOuCincoESeteBusiness;
        private const int TETOCALCULO = 1000;
        private const double CALCULOMULTIPLOTRESOUCINCOESETEESPERADO = 33173;

        [SetUp]
        public void SetUp()
        {
            calculoMultiplosTresOuCincoESeteBusiness =
                new CalculoMultiplosTresOuCincoESeteBusiness(new VerificacaoMultiploTresOuCincoESeteBusiness());
        }

        [Test]
        public void Deve_Retornar_Excecao_Quando_O_Teto_Calculo_For_Zero_Ou_Negativo()
        {
            Assert.Throws<BusinessException>(() => calculoMultiplosTresOuCincoESeteBusiness.Calcular(0), "Não deve realizar o cálculo quando o teto for zero!");
            Assert.Throws<BusinessException>(() => calculoMultiplosTresOuCincoESeteBusiness.Calcular(-1), "Não deve realizar o cálculo quando o teto for negativo!");
        }

        [Test]
        public void Deve_Retornar_33165_Quando_Teto_Calculo_For_Mil()
        {
            Assert.AreEqual(CALCULOMULTIPLOTRESOUCINCOESETEESPERADO,
                calculoMultiplosTresOuCincoESeteBusiness.Calcular(TETOCALCULO), $"O cálculo deve ser {CALCULOMULTIPLOTRESOUCINCOESETEESPERADO}!");
        }
    }
}