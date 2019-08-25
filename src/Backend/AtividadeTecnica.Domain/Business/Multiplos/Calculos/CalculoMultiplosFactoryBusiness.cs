using AtividadeTecnica.Domain.Business.Enums.Multiplos.Calculos;
using AtividadeTecnica.Domain.Business.Interfaces.Multiplos.Calculos;
using System;

namespace AtividadeTecnica.Domain.Business.Multiplos.Calculos
{
    public sealed class CalculoMultiplosFactoryBusiness : ICalculoMultiplosFactoryBusiness
    {
        private readonly ICalculoMultiplosTresOuCincoBusiness _calculoMultiplosTresOuCinco;
        private readonly ICalculoMultiplosTresECincoBusiness _calculoMultiplosTresECinco;
        private readonly ICalculoMultiplosTresOuCincoESeteBusiness _calculoMultiplosTresOuCincoESete;

        public CalculoMultiplosFactoryBusiness(ICalculoMultiplosTresOuCincoBusiness calculoMultiplosTresOuCinco,
            ICalculoMultiplosTresECincoBusiness calculoMultiplosTresECinco,
            ICalculoMultiplosTresOuCincoESeteBusiness calculoMultiplosTresOuCincoESete)
        {
            _calculoMultiplosTresOuCinco = calculoMultiplosTresOuCinco;
            _calculoMultiplosTresECinco = calculoMultiplosTresECinco;
            _calculoMultiplosTresOuCincoESete = calculoMultiplosTresOuCincoESete;
        }

        public ICalculoMultiplosBusiness BuildCalculoMultiplos(TipoMultiploCalculoEnum tipoMultiploCalculo)
        {
            switch (tipoMultiploCalculo)
            {
                case TipoMultiploCalculoEnum.MultiploTresOuCinco:
                    return _calculoMultiplosTresOuCinco;                    
                case TipoMultiploCalculoEnum.MultiploTresECinco:
                    return _calculoMultiplosTresECinco;
                case TipoMultiploCalculoEnum.MultiploTresOuCincoESete:
                    return _calculoMultiplosTresOuCincoESete;
                default:
                    throw new Exception("O tipo de múltiplo para realização do cálculo é inválido!");
            }
        }
    }
}