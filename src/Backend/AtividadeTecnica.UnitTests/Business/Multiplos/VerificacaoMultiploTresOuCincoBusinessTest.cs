using AtividadeTecnica.Domain.Business.Multiplos;
using NUnit.Framework;

namespace AtividadeTecnica.Domain.UnitTests.Business.Multiplos
{
    public class VerificacaoMultiploTresOuCincoBusinessTest
    {
        private VerificacaoMultiploTresOuCincoBusiness verificacaoMultiploTresOuCincoBusiness;
        private const int NUMERONAOMULTIPLOTRESOUCINCO = 44;
        private const int NUMEROMULTIPLOTRES = 15;
        private const int NUMEROMULTIPLOCINCO = 50;

        [SetUp]
        public void SetUp()
        {
            verificacaoMultiploTresOuCincoBusiness = new VerificacaoMultiploTresOuCincoBusiness();
        }

        [Test]
        public void Deve_Retornar_Falso_No_Caso_Do_Numero_Nao_Ser_Multiplo_Tres_Ou_Cinco()
        {
            Assert.IsFalse(verificacaoMultiploTresOuCincoBusiness.Verificar(NUMERONAOMULTIPLOTRESOUCINCO), "O número não deve ser múltiplo de três ou cinco!");
        }

        [Test]
        public void Deve_Retornar_Verdadeiro_No_Caso_Do_Numero_Ser_Multiplo_Tres_E_Cinco()
        {
            Assert.IsTrue(verificacaoMultiploTresOuCincoBusiness.Verificar(NUMEROMULTIPLOTRES), "O número deve ser múltiplo de três e cinco!");
            Assert.IsTrue(verificacaoMultiploTresOuCincoBusiness.Verificar(NUMEROMULTIPLOCINCO), "O número deve ser múltiplo de três e cinco!");
        }
    }
}