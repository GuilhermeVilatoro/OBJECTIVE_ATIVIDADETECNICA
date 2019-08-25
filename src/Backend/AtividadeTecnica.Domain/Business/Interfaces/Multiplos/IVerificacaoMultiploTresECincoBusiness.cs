namespace AtividadeTecnica.Domain.Business.Interfaces.Multiplos
{
    public interface IVerificacaoMultiploTresECincoBusiness
    {
        /// <summary>
        /// Responsável por verificar se um número é múltiplo de três e cinco.
        /// </summary>
        /// <param name="multiploTresECinco">Número que será verificado se é múltiplo</param>
        /// <returns>Retorna verdadeiro se for múltiplo de três e cinco</returns>
        bool Verificar(long multiploTresECinco);
    }
}