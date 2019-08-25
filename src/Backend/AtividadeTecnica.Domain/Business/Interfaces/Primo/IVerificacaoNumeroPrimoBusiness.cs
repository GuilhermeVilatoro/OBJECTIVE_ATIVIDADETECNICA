namespace AtividadeTecnica.Domain.Business.Interfaces.Primo
{
    public interface IVerificacaoNumeroPrimoBusiness
    {
        /// <summary>
        /// Responsável por realizar a verificação se um determinado número é primo.
        /// </summary>
        /// <param name="primo">Número que será verificado</param>
        /// <returns>Retorna verdadeiro se o número for primo</returns>
        bool Verificar(long primo);
    }
}