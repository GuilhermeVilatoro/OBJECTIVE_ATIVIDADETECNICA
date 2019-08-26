using AtividadeTecnica.Domain.Business.Dto;
using AtividadeTecnica.Domain.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AtividadeTecnica.Domain.Business.ProdutosCarrinho
{
    public class CalculoProdutosCarrinhoBusinessTest
    {
        private CarrinhoDto carrinhoMock;
        private ProdutoDto produtoMock;
        private UsuarioDto usuarioMock;
        private ProdutoCarrinhoDto produtoCarrinhoMock;
        private CalculoProdutosCarrinhoBusiness calculoProdutosCarrinhoBusiness;

        const decimal TOTALCOMFRETE = 129;
        const decimal TOTALSEMFRETE = 100;
        const decimal TOTALESPERADO = 198;

        [SetUp]
        public void SetUp()
        {
            carrinhoMock = new CarrinhoDto();
            produtoMock = new ProdutoDto();
            usuarioMock = new UsuarioDto();
            produtoCarrinhoMock = new ProdutoCarrinhoDto();

            produtoMock.Valor = 9;
            produtoMock.Nome = "Chave de fenda";

            usuarioMock.Nome = "Testador";
            usuarioMock.Cep = "87075090";

            produtoCarrinhoMock.Produto = produtoMock;
            produtoCarrinhoMock.Quantidade = 11;

            calculoProdutosCarrinhoBusiness = new CalculoProdutosCarrinhoBusiness();
        }

        [Test]
        public void Deve_Retornar_Excecao_Ao_Calcular_Soma_Produtos_Carrinho_Sem_Informar_O_Carrinho()
        {
            Assert.Throws<ArgumentNullException>(() => calculoProdutosCarrinhoBusiness.CalcularValorTotal(null), "Não Deve ser informado um carrinho de compras!");
        }

        [Test]
        public void Deve_Retornar_Zero_Sem_Frete_Ao_Calcular_Soma_Produtos_Carrinho_Sem_Informar_Produtos_No_Carrinho()
        {
            Assert.AreEqual(0, calculoProdutosCarrinhoBusiness.CalcularValorTotal(carrinhoMock), "Não deve ser informado produtos no carrinho de compras!");
        }

        [Test]
        public void Deve_Retornar_Excecao_Ao_Calcular_Soma_Produtos_Carrinho_Com_Soma_Menor_100_Sem_Informar_CEP_Do_Usuario_Do_Carrinho()
        {
            carrinhoMock.ProdutosCarrinho = new List<ProdutoCarrinhoDto> { produtoCarrinhoMock };
            Assert.Throws<BusinessException>(() =>
               calculoProdutosCarrinhoBusiness.CalcularValorTotal(carrinhoMock), "Não Deve CEP do usuário no carrinho de compras!");
        }

        [Test]
        public void Deve_Retornar_Excecao_Ao_Calcular_Soma_Produtos_Carrinho_Com_Total_Menor_100_Informando_CEP_Do_Usuario_Invalido()
        {
            carrinhoMock.ProdutosCarrinho = new List<ProdutoCarrinhoDto> { produtoCarrinhoMock };
            usuarioMock.Cep = "883338nn";
            carrinhoMock.Usuario = usuarioMock;
            Assert.Throws<BusinessException>(() =>
               calculoProdutosCarrinhoBusiness.CalcularValorTotal(carrinhoMock), "O CEP do usuário no carrinho de compras deve ser inválido!");
        }

        [Test]
        public void Deve_Retornar_Frete_Somado_Ao_Calcular_Produtos_Carrinho_Com_Total_Menor_100()
        {
            carrinhoMock.ProdutosCarrinho = new List<ProdutoCarrinhoDto> { produtoCarrinhoMock };            
            carrinhoMock.Usuario = usuarioMock;
            Assert.AreEqual(TOTALCOMFRETE, calculoProdutosCarrinhoBusiness.CalcularValorTotal(carrinhoMock),
                $"O total dos produtos com frete deve ser {TOTALCOMFRETE}!");
        }

        [Test]
        public void Deve_Retornar_Sem_Frete_Somado_Ao_Calcular_Produtos_Carrinho_Com_Total_De_Cem_Reais()
        {
            produtoCarrinhoMock.Produto.Valor = 100;
            produtoCarrinhoMock.Quantidade = 1;
            carrinhoMock.ProdutosCarrinho = new List<ProdutoCarrinhoDto> { produtoCarrinhoMock };
            carrinhoMock.Usuario = usuarioMock;
            Assert.AreEqual(TOTALSEMFRETE, calculoProdutosCarrinhoBusiness.CalcularValorTotal(carrinhoMock),
                $"O total dos produtos sem frete deve ser {TOTALSEMFRETE}!");
        }       

        [Test]
        public void Deve_Retornar_Sem_Frete_Somado_Ao_Calcular_Produtos_Carrinho_Com_Total_Maior_100()
        {
            carrinhoMock.ProdutosCarrinho = new List<ProdutoCarrinhoDto> { produtoCarrinhoMock, produtoCarrinhoMock };
            carrinhoMock.Usuario = usuarioMock;
        
            Assert.AreEqual(TOTALESPERADO, calculoProdutosCarrinhoBusiness.CalcularValorTotal(carrinhoMock),
                $"O total dos produtos sem frete deve ser {TOTALESPERADO}!");        
        }
    }
}