using AtividadeTecnica.Application.ViewModels;

namespace AtividadeTecnica.Application.Services.Interfaces
{
    public interface ICarrinhoService 
    {
        /// <summary>
        /// ServiçoResponsável por realizar o cálculo dos valores totais dos produtos do carrinho.
        /// </summary>
        /// <param name="carrinhoViewModel">Carrinho de compras com os produtos</param>
        /// <returns>Retorna o valor total dos produtos do carrinho</returns>
        decimal CalcularValorTotalProdutosCarrinho(CarrinhoViewModel carrinhoViewModel);
    }
}