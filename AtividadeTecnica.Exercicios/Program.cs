using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AtividadeTecnica.Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int somaValoresMultiplosTresOuCinco, somaValoresMultiplosTresECinco, somaValoresMultiplosTresOuCincoESete;
            SomarMultiplos(out somaValoresMultiplosTresOuCinco, out somaValoresMultiplosTresECinco, out somaValoresMultiplosTresOuCincoESete);

            Console.WriteLine($"A soma dos valores múltiplos de três ou cinco é: {somaValoresMultiplosTresOuCinco}!");
            Console.WriteLine($"A soma dos valores múltiplos de três e cinco é: {somaValoresMultiplosTresECinco}!");
            Console.WriteLine($"A soma dos valores múltiplos de três ou cinco e sete é: {somaValoresMultiplosTresOuCincoESete}!");

            Console.Write("Informe um número:  ");
            var identificadorFeliz = double.Parse(Console.ReadLine());
            var ehNumeroFeliz = VerificarNumeroFeliz(identificadorFeliz) ? "Sim" : "Não";
            Console.Write($"O número {identificadorFeliz} {ehNumeroFeliz} é um número feliz!");

            Console.Write("Informe um palavra:  ");
            var palavra = Console.ReadLine();
            var somaLetrasPalavra = CalcularPalavrasEmNumeros(palavra);


            var ehPrimo = VerificarNumeroPrimo(somaLetrasPalavra) ? string.Empty : "não";
            var ehFeliz = VerificarNumeroFeliz(somaLetrasPalavra) ? string.Empty : "não" ;
            var ehMultiplo = VerificarMultiploTresOuCinco(somaLetrasPalavra) ? string.Empty : "não";

            Console.Write($"A soma das letras da palavra '{palavra}' é : {somaLetrasPalavra}. " +
                $"Esse número {ehPrimo} é primo, {ehFeliz} é feliz e {ehMultiplo} é múltiplo de três ou cinco!");
        }

        private static int CalcularPalavrasEmNumeros(string palavra)
        {
            if (!Regex.IsMatch(palavra, @"^[a-zA-Z]+$"))
                throw new Exception("Informe uma palavra válida!");

            var dicionarioPalavras = new Dictionary<char, int>
            {
                { 'a', 1 }, { 'b', 2 }, { 'c', 3 }, { 'd', 4 }, { 'e', 5 }, { 'f', 6 },
                { 'g', 7 }, { 'h', 8 }, { 'i', 9 }, { 'j', 10 }, { 'k', 11 }, { 'l', 12 },
                { 'm', 13 }, { 'n', 14 }, { 'o', 15 }, { 'p', 16 }, { 'q', 17 },{ 'r', 18 },
                { 's', 19 }, { 't', 20 }, { 'u', 21 }, { 'v', 22 }, { 'w', 23 }, { 'x', 24 },
                { 'y', 25 }, { 'z', 26 }, { 'A', 27 }, { 'B', 28 }, { 'C', 29 }, { 'D', 30 },
                { 'E', 31 }, { 'F', 32 }, { 'G', 33 }, { 'H', 34 }, { 'I', 35 }, { 'J', 36 },
                { 'K', 37 }, { 'L', 38 }, { 'M', 39 }, { 'N', 40 }, { 'O', 41 }, { 'P', 42 },
                { 'Q', 43 }, { 'R', 44 }, { 'S', 45 }, { 'T', 46 }, { 'U', 47 }, { 'V', 48 },
                { 'W', 49 }, { 'X', 50 }, { 'Y', 51 }, { 'Z', 52 }
            };

            var somaLetras = 0;
            foreach (var letra in palavra)
                somaLetras += dicionarioPalavras[letra];

            return somaLetras;
        }

        private static bool VerificarMultiploTresOuCinco(int identificador)
        {
            return (identificador % 3 == 0 || identificador % 5 == 0);
        }

        public static bool VerificarNumeroPrimo(int identificador)
        {
            if (identificador < 2)
                return false;

            int quantidadeDivisores = 0;
            for (int contador = 1; contador <= identificador; contador++)
            {
                int resto = identificador % contador;
                if (resto == 0)
                    quantidadeDivisores++;
            }
            return quantidadeDivisores == 2;
        }

        private static void SomarMultiplos(out int somaValoresMultiplosTresOuCinco, out int somaValoresMultiplosTresECinco,
            out int somaValoresMultiplosTresOuCincoESete)
        {
            somaValoresMultiplosTresOuCinco = 0;
            somaValoresMultiplosTresECinco = 0;
            somaValoresMultiplosTresOuCincoESete = 0;
            for (int contador = 1; contador < 1000; contador++)
            {
                if (VerificarMultiploTresOuCinco(contador))
                    somaValoresMultiplosTresOuCinco += contador;

                if (contador % 3 == 0 && contador % 5 == 0)
                    somaValoresMultiplosTresECinco += contador;

                if ((contador % 3 == 0 || contador % 5 == 0) && contador % 7 == 0)
                    somaValoresMultiplosTresOuCincoESete += contador;
            }
        }

        private static bool VerificarNumeroFeliz(double identificadorFeliz)
        {
            if (identificadorFeliz < 0)
                throw new Exception("O número feliz deve ser positivo!");

            identificadorFeliz = Math.Pow(identificadorFeliz, 2);
            var processamentoNumerosFelizes = new List<double>() { identificadorFeliz };

            while (identificadorFeliz != 1)
            {
                double felizAux = 0;

                double digitoFeliz;
                while (identificadorFeliz > 0)
                {
                    digitoFeliz = identificadorFeliz % 10;

                    felizAux += Math.Pow(digitoFeliz, 2);
                    identificadorFeliz = (identificadorFeliz - digitoFeliz) / 10;
                }

                if (processamentoNumerosFelizes.Any(x => x == felizAux))
                    return false;

                processamentoNumerosFelizes.Add(felizAux);
                identificadorFeliz = felizAux;
            }
            return true;
        }
    }
}
