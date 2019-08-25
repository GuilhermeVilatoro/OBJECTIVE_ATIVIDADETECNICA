namespace AtividadeTecnica.Domain.Business.Interfaces.Multiplos
{
    public interface IVerificacaoMultiploTresOuCincoESeteBusiness
    {
        /// <summary>
        /// Responsável por verificar se um número é múltiplo de três ou cinco e sete.
        /// </summary>
        /// <param name="multiploTresOuCincoESete">Número que será verificado se é múltiplo</param>
        /// <returns>Retorna verdadeiro se for múltiplo de três ou cinco e sete</returns>
        bool Verificar(long multiploTresOuCincoESete);
    }
}