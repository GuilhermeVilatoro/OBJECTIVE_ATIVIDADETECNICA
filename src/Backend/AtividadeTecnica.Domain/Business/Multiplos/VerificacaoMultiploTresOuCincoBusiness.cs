using AtividadeTecnica.Domain.Business.Interfaces.Multiplos;

namespace AtividadeTecnica.Domain.Business.Multiplos
{
    public sealed class VerificacaoMultiploTresOuCincoBusiness : IVerificacaoMultiploTresOuCincoBusiness
    {
        public bool Verificar(long multiploTresOuCinco)
        {
            return (multiploTresOuCinco % 3 == 0 || multiploTresOuCinco % 5 == 0);
        }
    }
}