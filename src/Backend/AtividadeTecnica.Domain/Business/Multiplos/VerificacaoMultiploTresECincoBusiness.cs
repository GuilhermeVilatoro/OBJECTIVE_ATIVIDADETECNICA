using AtividadeTecnica.Domain.Business.Interfaces.Multiplos;

namespace AtividadeTecnica.Domain.Business.Multiplos
{
    public sealed class VerificacaoMultiploTresECincoBusiness : IVerificacaoMultiploTresECincoBusiness
    {
        public bool Verificar(long multiploTresECinco)
        {
            return (multiploTresECinco % 3 == 0 && multiploTresECinco % 5 == 0);
        }
    }
}