namespace AtividadeTecnica.Domain.Business.Interfaces.Feliz
{
    public interface IVerificacaoNumeroFelizBusiness
    {
        /// <summary>
        /// Responsável por realizar a verificação se um número é feliz
        /// </summary>
        /// <param name="feliz">Número informado que será verificado</param>
        /// <returns>Retorna verdadeiro se o número informado for feliz</returns>
        bool Verificar(double feliz);
    }
}