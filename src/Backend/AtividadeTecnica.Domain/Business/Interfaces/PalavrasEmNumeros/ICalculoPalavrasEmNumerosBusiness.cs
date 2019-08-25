namespace AtividadeTecnica.Domain.Business.Interfaces.PalavrasEmNumeros
{
    public interface ICalculoPalavrasEmNumerosBusiness
    {
        /// <summary>
        /// Responsável por realizar a soma dos respectivos valores de cada letra em uma palavra.
        /// </summary>
        /// <param name="palavraEmNumero">Palavra que será realizado o cálculo</param>
        /// <returns>retorna o valor calculado das soma das letras da palavra informada</returns>
        long Calcular(string palavraEmNumero);
    }
}