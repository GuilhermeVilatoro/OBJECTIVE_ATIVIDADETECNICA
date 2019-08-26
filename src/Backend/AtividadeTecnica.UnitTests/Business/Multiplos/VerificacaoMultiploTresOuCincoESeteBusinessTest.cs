using AtividadeTecnica.Domain.Business.Multiplos;
using NUnit.Framework;

namespace AtividadeTecnica.Domain.UnitTests.Business.Multiplos
{
    public class VerificacaoMultiploTresOuCincoESeteBusinessTest
    {
        private VerificacaoMultiploTresOuCincoESeteBusiness verificacaoMultiploTresOuCincoESeteBusiness;
        private const int NUMERONAOMULTIPLOTRESOUCINCOESETE = 40;
        private const int NUMEROMULTIPLOTRES = 15;
        private const int NUMEROMULTIPLOCINCO = 50;
        private const int NUMEROMULTIPLOSETE = 49;
        private const int NUMEROMULTIPLOTRESESETE = 21;
        private const int NUMEROMULTIPLOCINCOESETE = 35;

        [SetUp]
        public void SetUp()
        {
            verificacaoMultiploTresOuCincoESeteBusiness = new VerificacaoMultiploTresOuCincoESeteBusiness();
        }

        [Test]
        public void Deve_Retornar_Falso_No_Caso_Do_Numero_Nao_Ser_Multiplo_Tres_Ou_Cinco_E_Sete()
        {
            Assert.IsFalse(verificacaoMultiploTresOuCincoESeteBusiness
                .Verificar(NUMERONAOMULTIPLOTRESOUCINCOESETE), "O número não deve ser múltiplo de três ou cinco e sete!");
            Assert.IsFalse(verificacaoMultiploTresOuCincoESeteBusiness.Verificar(NUMEROMULTIPLOTRES), "O número não deve ser múltiplo de três ou cinco e sete!");
            Assert.IsFalse(verificacaoMultiploTresOuCincoESeteBusiness.Verificar(NUMEROMULTIPLOCINCO), "O número não deve ser múltiplo de três ou cinco e sete!");
            Assert.IsFalse(verificacaoMultiploTresOuCincoESeteBusiness.Verificar(NUMEROMULTIPLOSETE), "O número não deve ser múltiplo de três ou cinco e sete!");
        }

        [Test]
        public void Deve_Retornar_Verdadeiro_No_Caso_Do_Numero_Ser_Multiplo_Tres_Ou_Cinco_E_Sete()
        {
            Assert.IsTrue(verificacaoMultiploTresOuCincoESeteBusiness.Verificar(NUMEROMULTIPLOTRESESETE), "O número deve ser múltiplo de três ou cinco e sete!");
            Assert.IsTrue(verificacaoMultiploTresOuCincoESeteBusiness.Verificar(NUMEROMULTIPLOCINCOESETE), "O número deve ser múltiplo de três ou cinco e sete!");
        }
    }
}