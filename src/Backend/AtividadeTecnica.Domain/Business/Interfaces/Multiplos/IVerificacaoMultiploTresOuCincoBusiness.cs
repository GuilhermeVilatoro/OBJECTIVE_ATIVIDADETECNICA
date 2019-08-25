namespace AtividadeTecnica.Domain.Business.Interfaces.Multiplos
{
    public interface IVerificacaoMultiploTresOuCincoBusiness
    {
        /// <summary>
        /// Responsável por verificar se um número é múltiplo de três ou cinco.
        /// </summary>
        /// <param name="multiploTresOuCinco">Número que será verificado se é múltiplo</param>
        /// <returns>Retorna verdadeiro se for múltiplo de três ou cinco</returns>
        bool Verificar(long multiploTresOuCinco);
    }
}