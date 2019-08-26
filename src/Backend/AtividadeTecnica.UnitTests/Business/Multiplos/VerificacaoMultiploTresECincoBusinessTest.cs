using AtividadeTecnica.Domain.Business.Multiplos;
using NUnit.Framework;

namespace AtividadeTecnica.Domain.UnitTests.Business.Multiplos
{
    public class VerificacaoMultiploTresECincoBusinessTest
    {
        private VerificacaoMultiploTresECincoBusiness verificacaoMultiploTresECincoBusiness;
        private const int NUMERONAOMULTIPLOTRESECINCO = 50;
        private const int NUMEROMULTIPLOTRESECINCO = 15;

        [SetUp]
        public void SetUp()
        {
            verificacaoMultiploTresECincoBusiness = new VerificacaoMultiploTresECincoBusiness();
        }       

        [Test]
        public void Deve_Retornar_Falso_No_Caso_Do_Numero_Nao_Ser_Multiplo_Tres_E_Cinco()
        {
            Assert.IsFalse(verificacaoMultiploTresECincoBusiness.Verificar(NUMERONAOMULTIPLOTRESECINCO), "O número não deve ser múltiplo de três e cinco!");
        }

        [Test]
        public void Deve_Retornar_Verdadeiro_No_Caso_Do_Numero_Ser_Multiplo_Tres_E_Cinco()
        {
            Assert.IsTrue(verificacaoMultiploTresECincoBusiness.Verificar(NUMEROMULTIPLOTRESECINCO), "O número deve ser múltiplo de três e cinco!");
        }
    }
}