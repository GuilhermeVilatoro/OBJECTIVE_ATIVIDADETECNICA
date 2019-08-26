using AtividadeTecnica.Application.Services.Interfaces;
using AtividadeTecnica.Application.ViewModels;
using AtividadeTecnica.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeTecnica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrinhoController : ApiController
    {
        private readonly ICarrinhoService _carrinhoService;

        public CarrinhoController(ICarrinhoService carrinhoService)
        {
            _carrinhoService = carrinhoService;
        }

        /// <summary>
        /// Faz o cálculo do valor total dos produtos em um carrinho de compras em memória.        
        /// <param name="carrinhoViewModel">Contem as informações do carrinho de compras como os produtos</param>        
        /// <returns>O resultado será o valor do cálculo sem arredondamento, formatado com duas casas decimais.</returns>
        /// <response code="200">O resultado será o valor do cálculo sem arredondamento, formatado com duas casas decimais</response>
        /// </summary>
        [HttpPost]
        [Route("calcularTotalProdutos")]
        public IActionResult CalcularTotalProdutos(CarrinhoViewModel carrinhoViewModel)
        {
            if (!ModelState.IsValid)
                return Response(carrinhoViewModel);

            try
            {
                var retorno = _carrinhoService.CalcularValorTotalProdutosCarrinho(carrinhoViewModel);
                return Response(retorno.ToString("N2"));
            }
            catch (BusinessException ex)
            {
                return new ObjectResult($"Erro ao calcular valor total produtos no carrinho: {ex.Message}");
            }
        }
    }
}