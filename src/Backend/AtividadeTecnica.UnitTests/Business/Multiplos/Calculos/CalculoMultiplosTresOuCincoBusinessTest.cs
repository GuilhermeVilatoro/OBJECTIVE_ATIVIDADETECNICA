using AtividadeTecnica.Domain.Business.Multiplos;
using AtividadeTecnica.Domain.Business.Multiplos.Calculos;
using AtividadeTecnica.Domain.Exceptions;
using NUnit.Framework;

namespace AtividadeTecnica.Domain.UnitTests.Multiplos.Calculos
{
    public class CalculoMultiplosTresOuCincoBusinessTest 
    {
        private CalculoMultiplosTresOuCincoBusiness calculoMultiplosTresOuCincoBusiness;
        private const int TETOCALCULO = 1000;
        private const double CALCULOMULTIPLOTRESOUCINCOESPERADO = 233168;

        [SetUp]
        public void SetUp()
        {
            calculoMultiplosTresOuCincoBusiness = new CalculoMultiplosTresOuCincoBusiness(new VerificacaoMultiploTresOuCincoBusiness());
        }

        [Test]
        public void Deve_Retornar_Excecao_Quando_O_Teto_Calculo_For_Zero_Ou_Negativo()
        {
            Assert.Throws<BusinessException>(() => calculoMultiplosTresOuCincoBusiness.Calcular(0), "Não deve realizar o cálculo quando o teto for zero!");
            Assert.Throws<BusinessException>(() => calculoMultiplosTresOuCincoBusiness.Calcular(-1), "Não deve realizar o cálculo quando o teto for negativo!");
        }

        [Test]
        public void Deve_Retornar_233168_Quando_Teto_Calculo_For_Mil()
        {
            Assert.AreEqual(CALCULOMULTIPLOTRESOUCINCOESPERADO,
                calculoMultiplosTresOuCincoBusiness.Calcular(TETOCALCULO), $"O cálculo deve ser {CALCULOMULTIPLOTRESOUCINCOESPERADO}!");
        }
    }
}