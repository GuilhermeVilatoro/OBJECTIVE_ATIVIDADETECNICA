using AtividadeTecnica.Domain.Business.Dto;
using AtividadeTecnica.Domain.Business.Interfaces.ProdutosCarrinho;
using AtividadeTecnica.Domain.Exceptions;
using System.Linq;
using System.Text.RegularExpressions;

namespace AtividadeTecnica.Domain.Business.ProdutosCarrinho
{
    public sealed class CalculoProdutosCarrinhoBusiness : ICalculoProdutosCarrinhoBusiness
    {
        private const int TETOFRETE = 100;
        private const decimal VALORFRETE = 30;

        public decimal CalcularValorTotal(CarrinhoDto carrinho)
        {
            if (carrinho == null)
                throw new System.ArgumentNullException(nameof(carrinho));

            if (!carrinho.ProdutosCarrinho.Any())
                return 0;            

            var totalCarrinho = carrinho.ProdutosCarrinho.Sum(x => x.Produto.Valor * x.Quantidade);
            if (totalCarrinho < TETOFRETE)
                totalCarrinho += CalcularValorFretePorCepUsuario(carrinho.Usuario?.Cep);

            return totalCarrinho;
        }

        private decimal CalcularValorFretePorCepUsuario(string cep)
        {
            if (string.IsNullOrEmpty(cep) || !Regex.IsMatch(cep, @"^[0-9]+$"))
                throw new BusinessException("O usuário não tem CEP, para verificar o valor do frete!");

            return VALORFRETE;
        }
    }
}