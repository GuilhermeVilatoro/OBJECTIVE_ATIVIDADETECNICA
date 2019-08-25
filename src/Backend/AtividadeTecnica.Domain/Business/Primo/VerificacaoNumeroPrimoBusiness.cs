using AtividadeTecnica.Domain.Business.Interfaces.Primo;

namespace AtividadeTecnica.Domain.Business.Primo
{
    public sealed class VerificacaoNumeroPrimoBusiness : IVerificacaoNumeroPrimoBusiness
    {
        public bool Verificar(long primo)
        {
            if (primo < 2)
                return false;

            int quantidadeDivisores = 0;
            for (long contador = 1; contador <= primo; contador++)
            {
                if (primo % contador == 0)
                    quantidadeDivisores++;
            }
            return quantidadeDivisores == 2;
        }
    }
}