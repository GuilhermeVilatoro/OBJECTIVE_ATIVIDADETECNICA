using AtividadeTecnica.Application.Services.Interfaces;
using AtividadeTecnica.Application.ViewModels;
using AtividadeTecnica.Domain.Business.Dto;
using AtividadeTecnica.Domain.Business.Interfaces.ProdutosCarrinho;
using AutoMapper;

namespace AtividadeTecnica.Application.Services
{
    public class CarrinhoService : ICarrinhoService
    {
        private readonly ICalculoProdutosCarrinhoBusiness _calculoProdutosCarrinhoBusiness;        

        public CarrinhoService(ICalculoProdutosCarrinhoBusiness calculoProdutosCarrinhoBusiness)
        {            
            _calculoProdutosCarrinhoBusiness = calculoProdutosCarrinhoBusiness;
        }

        public decimal CalcularValorTotalProdutosCarrinho(CarrinhoViewModel carrinhoViewModel)
        {
            if (carrinhoViewModel == null)
                throw new System.ArgumentNullException(nameof(carrinhoViewModel));

            var carrinhoDto = Mapper.Map<CarrinhoDto>(carrinhoViewModel);

            return _calculoProdutosCarrinhoBusiness.CalcularValorTotal(carrinhoDto);
        }
    }
}