using AtividadeTecnica.Domain.Business.PalavrasEmNumeros;
using AtividadeTecnica.Domain.Exceptions;
using NUnit.Framework;

namespace AtividadeTecnica.Domain.UnitTests.PalavrasEmNumeros
{
    public class CalculoPalavrasEmNumerosBusinessTest
    {
        private CalculoPalavrasEmNumerosBusiness calculoPalavrasEmNumerosBusiness;
        private const int CALCULOATIVIDADETECNICAESPERADO = 182;        

        [SetUp]
        public void SetUp()
        {
            calculoPalavrasEmNumerosBusiness = new CalculoPalavrasEmNumerosBusiness();
        }

        [Test]
        public void Deve_Retornar_Excecao_Ao_Calcular_Soma_Informando_Palavra_Vazia_Ou_Nula()
        {
            Assert.Throws<BusinessException>(() => calculoPalavrasEmNumerosBusiness.Calcular(string.Empty), "Não será realizado o cálculo sem informar a palavra!");
            Assert.Throws<BusinessException>(() => calculoPalavrasEmNumerosBusiness.Calcular(null), "Não será realizado o cálculo sem informar a palavra!");            
        }

        [Test]
        public void Deve_Retornar_Excecao_Ao_Calcular_Soma_Informando_Palavra_Invalida()
        {
            Assert.Throws<BusinessException>(() => calculoPalavrasEmNumerosBusiness.Calcular("teste1234"), "Não será realizado o cálculo de uma palavra inválida!");
            Assert.Throws<BusinessException>(() => calculoPalavrasEmNumerosBusiness.Calcular("Avião"), "Não será realizado o cálculo de uma palavra inválida!");
        }

        [Test]
        public void Deve_Retornar_182_Quando_A_Palavra_For_AtividadeTecnica()
        {
            Assert.AreEqual(CALCULOATIVIDADETECNICAESPERADO, 
                calculoPalavrasEmNumerosBusiness.Calcular("AtividadeTecnica"), $"O cálculo deve ser {CALCULOATIVIDADETECNICAESPERADO}!");
        }       
    }
}