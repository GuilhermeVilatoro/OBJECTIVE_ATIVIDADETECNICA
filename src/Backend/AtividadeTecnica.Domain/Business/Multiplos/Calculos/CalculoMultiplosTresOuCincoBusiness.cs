using AtividadeTecnica.Domain.Business.Interfaces.Multiplos;
using AtividadeTecnica.Domain.Business.Interfaces.Multiplos.Calculos;
using System;

namespace AtividadeTecnica.Domain.Business.Multiplos.Calculos
{
    public sealed class CalculoMultiplosTresOuCincoBusiness : ICalculoMultiplosTresOuCincoBusiness
    {
        private readonly IVerificacaoMultiploTresOuCincoBusiness _verificacaoMultiploTresOuCinco;

        public CalculoMultiplosTresOuCincoBusiness(IVerificacaoMultiploTresOuCincoBusiness verificacaoMultiploTresOuCinco)
        {
            _verificacaoMultiploTresOuCinco = verificacaoMultiploTresOuCinco;
        }

        public long Calcular(long tetoCalculo)
        {
            if (tetoCalculo <= 0)
                throw new Exception("O teto para realização do cálculo dos múltiplos deve ser maior que zero!");

            long somaValoresMultiplosTresOuCinco = 0;
            for (int contador = 1; contador < tetoCalculo; contador++)
            {
                if (_verificacaoMultiploTresOuCinco.Verificar(contador))
                    somaValoresMultiplosTresOuCinco += contador;
            }
            return somaValoresMultiplosTresOuCinco;
        }
    }
}