using AtividadeTecnica.Domain.Business.Feliz;
using AtividadeTecnica.Domain.Exceptions;
using NUnit.Framework;

namespace AtividadeTecnica.Domain.UnitTests.Business.Feliz
{
    public class VerificacaoNumeroFelizBusinessTest
    {
        private VerificacaoNumeroFelizBusiness verificacaoNumeroFelizBusiness;
        private const int NUMEROINFELIZ = 5;
        private const int NUMEROFELIZ = 7;

        [SetUp]
        public void SetUp()
        {
            verificacaoNumeroFelizBusiness = new VerificacaoNumeroFelizBusiness();
        }

        [Test]
        public void Deve_Retornar_Excecao_Ao_Verificar_Um_Numero_Feliz_Negativo()
        {
            Assert.Throws<BusinessException>(() => verificacaoNumeroFelizBusiness.Verificar(-1), "O número feliz deve ser maior positivo!");
        }

        [Test]
        public void Deve_Retornar_Falso_No_Caso_Do_Numero_Nao_Ser_Feliz()
        {
            Assert.IsFalse(verificacaoNumeroFelizBusiness.Verificar(NUMEROINFELIZ), "O número não deve ser feliz!");
        }

        [Test]
        public void Deve_Retornar_Verdadeiro_No_Caso_Do_Numero_Ser_Feliz()
        {
            Assert.IsTrue(verificacaoNumeroFelizBusiness.Verificar(NUMEROFELIZ), "O número deve ser feliz!");
        }      
    }
}