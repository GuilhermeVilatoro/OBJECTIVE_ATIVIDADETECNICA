using AtividadeTecnica.Domain.Business.Enums.Multiplos.Calculos;

namespace AtividadeTecnica.Domain.Business.Interfaces.Multiplos.Calculos
{
    public interface ICalculoMultiplosFactoryBusiness
    {
        /// <summary>
        /// Responsáve por construir o cálculo de acordo com os múltiplos.
        /// </summary>
        /// <param name="tipoMultiploCalculo">Tipo de múltiplos, os quais serão realizados os cálculos</param>
        /// <returns>Retorna a instância de acordo com o tipo de múltiplo para realizar o cálculo</returns>
        ICalculoMultiplosBusiness BuildCalculoMultiplos(TipoMultiploCalculoEnum tipoMultiploCalculo);
    }
}