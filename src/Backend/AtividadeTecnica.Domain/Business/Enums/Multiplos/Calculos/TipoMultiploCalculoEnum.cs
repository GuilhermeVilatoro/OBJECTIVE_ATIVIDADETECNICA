using System.ComponentModel;

namespace AtividadeTecnica.Domain.Business.Enums.Multiplos.Calculos
{
    public enum TipoMultiploCalculoEnum
    {
        [Description("Múltiplo de três ou cinco")]
        MultiploTresOuCinco = 1,

        [Description("Múltiplo de três e cinco")]
        MultiploTresECinco = 2,

        [Description("Múltiplo de três ou cinco e sete")]
        MultiploTresOuCincoESete = 3
    }
}