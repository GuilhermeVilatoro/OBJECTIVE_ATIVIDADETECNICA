using AtividadeTecnica.Domain.Business.Primo;
using NUnit.Framework;

namespace AtividadeTecnica.Domain.UnitTests.Business.Primo
{
    public class VerificacaoNumeroPrimoBusinessTest
    {
        private VerificacaoNumeroPrimoBusiness verificacaoNumeroPrimoBusiness;
        private const int NUMERONAOPRIMO = 20;
        private const int NUMEROPRIMO = 7;

        [SetUp]
        public void SetUp()
        {
            verificacaoNumeroPrimoBusiness = new VerificacaoNumeroPrimoBusiness();
        }

        [Test]
        public void Deve_Retornar_Falso_Ao_Verificar_Um_Numero_Feliz_Negativo()
        {
            Assert.IsFalse(verificacaoNumeroPrimoBusiness.Verificar(1), "Todo número menor que dois não é primo!");
        }

        [Test]
        public void Deve_Retornar_Falso_No_Caso_Do_Numero_Nao_Ser_Primo()
        {
            Assert.IsFalse(verificacaoNumeroPrimoBusiness.Verificar(NUMERONAOPRIMO), "O número não deve ser primo!");
        }

        [Test]
        public void Deve_Retornar_Verdadeiro_No_Caso_Do_Numero_Ser_Primo()
        {
            Assert.IsTrue(verificacaoNumeroPrimoBusiness.Verificar(NUMEROPRIMO), "O número deve ser primo!");
        }
    }
}