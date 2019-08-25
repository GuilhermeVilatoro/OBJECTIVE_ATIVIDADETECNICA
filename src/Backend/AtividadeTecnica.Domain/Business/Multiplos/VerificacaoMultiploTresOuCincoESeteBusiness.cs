using AtividadeTecnica.Domain.Business.Interfaces.Multiplos;

namespace AtividadeTecnica.Domain.Business.Multiplos
{
    public sealed class VerificacaoMultiploTresOuCincoESeteBusiness : IVerificacaoMultiploTresOuCincoESeteBusiness
    {
        public bool Verificar(long multiploTresOuCincoESete)
        {
            return ((multiploTresOuCincoESete % 3 == 0 || multiploTresOuCincoESete % 5 == 0) && multiploTresOuCincoESete % 7 == 0);
        }
    }
}