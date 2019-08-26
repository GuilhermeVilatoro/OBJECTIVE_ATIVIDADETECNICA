using AtividadeTecnica.Domain.Business.Interfaces.Multiplos;
using AtividadeTecnica.Domain.Business.Interfaces.Multiplos.Calculos;
using AtividadeTecnica.Domain.Exceptions;

namespace AtividadeTecnica.Domain.Business.Multiplos.Calculos
{
    public sealed class CalculoMultiplosTresECincoBusiness : ICalculoMultiplosTresECincoBusiness
    {
        private readonly IVerificacaoMultiploTresECincoBusiness _verificacaoMultiploTresECinco;

        public CalculoMultiplosTresECincoBusiness(IVerificacaoMultiploTresECincoBusiness verificacaoMultiploTresECinco)
        {
            _verificacaoMultiploTresECinco = verificacaoMultiploTresECinco;
        }

        public long Calcular(long tetoCalculo)
        {
            if (tetoCalculo <= 0)
                throw new BusinessException("O teto para realização do cálculo dos múltiplos deve ser maior que zero!");

            long somaValoresMultiplosTresECinco = 0;
            for (int contador = 1; contador < tetoCalculo; contador++)
            {
                if (_verificacaoMultiploTresECinco.Verificar(contador))
                    somaValoresMultiplosTresECinco += contador;
            }
            return somaValoresMultiplosTresECinco;
        }
    }
}