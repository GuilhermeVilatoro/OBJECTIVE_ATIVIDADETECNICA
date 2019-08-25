using AtividadeTecnica.Domain.Business.Interfaces.Feliz;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AtividadeTecnica.Domain.Business.Feliz
{
    public sealed class VerificacaoNumeroFelizBusiness : IVerificacaoNumeroFelizBusiness
    {
        public bool Verificar(double feliz)
        {
            if (feliz < 0)
                throw new Exception("O número feliz deve ser positivo!");

            feliz = Math.Pow(feliz, 2);
            var processamentoNumerosFelizes = new List<double>() { feliz };

            while (feliz != 1)
            {
                double felizAuxiliar = 0;

                double digitoFeliz;
                while (feliz > 0)
                {
                    digitoFeliz = feliz % 10;

                    felizAuxiliar += Math.Pow(digitoFeliz, 2);
                    feliz = (feliz - digitoFeliz) / 10;
                }

                if (processamentoNumerosFelizes.Any(numerofeliz => numerofeliz == felizAuxiliar))
                    return false;

                processamentoNumerosFelizes.Add(felizAuxiliar);
                feliz = felizAuxiliar;
            }
            return true;
        }
    }
}