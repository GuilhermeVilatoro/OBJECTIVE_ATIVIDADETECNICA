using AtividadeTecnica.Domain.Business.Interfaces.Multiplos;
using AtividadeTecnica.Domain.Business.Interfaces.Multiplos.Calculos;
using System;

namespace AtividadeTecnica.Domain.Business.Multiplos.Calculos
{
    public sealed class CalculoMultiplosTresOuCincoESeteBusiness : ICalculoMultiplosTresOuCincoESeteBusiness
    {
        private readonly IVerificacaoMultiploTresOuCincoESeteBusiness _verificacaoMultiploTresOuCincoESete;

        public CalculoMultiplosTresOuCincoESeteBusiness(IVerificacaoMultiploTresOuCincoESeteBusiness verificacaoMultiploTresOuCincoESete)
        {
            _verificacaoMultiploTresOuCincoESete = verificacaoMultiploTresOuCincoESete;
        }

        public long Calcular(long tetoCalculo)
        {
            if (tetoCalculo <= 0)
                throw new Exception("O teto para realização do cálculo dos múltiplos deve ser maior que zero!");

            long somaValoresMultiplosTresOuCincoESete = 0;
            for (int contador = 1; contador < tetoCalculo; contador++)
            {
                if (_verificacaoMultiploTresOuCincoESete.Verificar(contador))
                    somaValoresMultiplosTresOuCincoESete += contador;
            }
            return somaValoresMultiplosTresOuCincoESete;
        }
    }
}