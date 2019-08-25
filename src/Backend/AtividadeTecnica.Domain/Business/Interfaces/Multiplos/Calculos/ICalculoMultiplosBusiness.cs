namespace AtividadeTecnica.Domain.Business.Interfaces.Multiplos.Calculos
{
    public interface ICalculoMultiplosBusiness
    {
        /// <summary>
        /// Responsável por realizar o cálculo da soma dos múltiplos de acordo com um teto de cálculo.
        /// </summary>
        /// <param name="tetoCalculo">Teto para realização do cálculo</param>
        /// <returns>Retorna o cálculo de acordo com o teto e os múltiplos correspondentes</returns>
        long Calcular(long tetoCalculo);
    }
}