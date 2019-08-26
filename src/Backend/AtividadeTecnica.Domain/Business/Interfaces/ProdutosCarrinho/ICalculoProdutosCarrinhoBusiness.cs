using AtividadeTecnica.Domain.Business.Dto;

namespace AtividadeTecnica.Domain.Business.Interfaces.ProdutosCarrinho
{
    public interface ICalculoProdutosCarrinhoBusiness
    {
        /// <summary>
        /// Responsável por realizar o cálculo dos valores totais dos produtos do carrinho.
        /// </summary>
        /// <param name="carrinho">Carrinho de compras com os produtos</param>
        /// <returns>Retorna o valor total dos produtos do carrinho</returns>
        decimal CalcularValorTotal(CarrinhoDto carrinho);
    }
}