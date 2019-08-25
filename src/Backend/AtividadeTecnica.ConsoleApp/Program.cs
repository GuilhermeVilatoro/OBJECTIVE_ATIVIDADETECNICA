using AtividadeTecnica.ConsoleApp.Configurations;
using AtividadeTecnica.Domain.Business.Enums.Multiplos.Calculos;
using AtividadeTecnica.Domain.Business.Interfaces.Feliz;
using AtividadeTecnica.Domain.Business.Interfaces.Multiplos;
using AtividadeTecnica.Domain.Business.Interfaces.Multiplos.Calculos;
using AtividadeTecnica.Domain.Business.Interfaces.PalavrasEmNumeros;
using AtividadeTecnica.Domain.Business.Interfaces.Primo;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AtividadeTecnica.ConsoleApp
{
    class Program
    {
        private const long TETOCALCULO = 1000;

        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfiguracaoInjecaoDependencias.Configurar();
            var verificacaoNumeroPrimo = serviceProvider.GetService<IVerificacaoNumeroPrimoBusiness>();
            var verificacaoNumeroFeliz = serviceProvider.GetService<IVerificacaoNumeroFelizBusiness>();
            var calculoMultiplosFactory = serviceProvider.GetService<ICalculoMultiplosFactoryBusiness>();
            var verificacaoMultiploTresOuCinco = serviceProvider.GetService<IVerificacaoMultiploTresOuCincoBusiness>();
            var calculoPalavrasEmNumeros = serviceProvider.GetService<ICalculoPalavrasEmNumerosBusiness>();

            int opcaoEscolhida = 0;
            do
            {
                try
                {
                    opcaoEscolhida = ExibirMenu();
                    switch (Convert.ToInt32(opcaoEscolhida))
                    {
                        case 1:
                            Console.WriteLine($"A soma dos valores múltiplos de três ou cinco é: " +
                              $"{calculoMultiplosFactory.BuildCalculoMultiplos(TipoMultiploCalculoEnum.MultiploTresOuCinco).Calcular(TETOCALCULO)}!\n");
                            break;
                        case 2:
                            Console.WriteLine($"A soma dos valores múltiplos de três e cinco é: " +
                               $"{calculoMultiplosFactory.BuildCalculoMultiplos(TipoMultiploCalculoEnum.MultiploTresECinco).Calcular(TETOCALCULO)}!\n");
                            break;
                        case 3:
                            Console.WriteLine($"A soma dos valores múltiplos de três ou cinco e sete é: " +
                                $"{calculoMultiplosFactory.BuildCalculoMultiplos(TipoMultiploCalculoEnum.MultiploTresOuCincoESete).Calcular(TETOCALCULO)}!\n");
                            break;
                        case 4:
                            Console.WriteLine("Informe um número: ");
                            var identificadorFeliz = double.Parse(Console.ReadLine());
                            var isNumeroFeliz = verificacaoNumeroFeliz.Verificar(identificadorFeliz) ? string.Empty : " não";
                            Console.WriteLine($"O número '{identificadorFeliz}'{isNumeroFeliz} é um número feliz!");
                            break;
                        case 5:
                            Console.WriteLine("Informe uma palavra: ");
                            var palavra = Console.ReadLine();
                            var somaLetrasPalavra = calculoPalavrasEmNumeros.Calcular(palavra);
                            var isPrimo = verificacaoNumeroPrimo.Verificar(somaLetrasPalavra) ? string.Empty : " não";
                            var isFeliz = verificacaoNumeroFeliz.Verificar(somaLetrasPalavra) ? string.Empty : " não";
                            var isMultiplo = verificacaoMultiploTresOuCinco.Verificar(somaLetrasPalavra) ? string.Empty : " não";

                            Console.WriteLine($"A soma das letras da palavra '{palavra}' é : {somaLetrasPalavra}. " +
                                $"Esse número{isPrimo} é primo,{isFeliz} é feliz e{isMultiplo} é múltiplo de três ou cinco!\n");
                            break;
                        case 6:
                            throw new Exception("Cálculo de Juros está implementado nna API WEB!");
                        case 7:
                            Console.WriteLine("Saindo!");
                            break;
                       default:
                            throw new Exception("Opção selecionada inválida!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}{Environment.NewLine}");                    
                }
            } while (opcaoEscolhida != 7);                             
        }

        /// <summary>
        /// Responsável por exibir as opções do menu a cada iteração.
        /// </summary>
        /// <returns>Exibe as opções do menu</returns>
        static int ExibirMenu()
        {
            Console.WriteLine("Atividade Técnica em C#\n\r");            

            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("\t 1 - Soma dos múltiplos de três ou cinco menores que mil");
            Console.WriteLine("\t 2 - Soma dos múltiplos de três e cinco menores que mil");
            Console.WriteLine("\t 3 - Soma dos múltiplos de três ou cinco e sete menores que mil");
            Console.WriteLine("\t 4 - Verificação de número feliz");
            Console.WriteLine("\t 5 - Verificação de palavras e números");
            Console.WriteLine("\t 6 - Cálculo de Juros");
            Console.WriteLine("\t 7 - Sair");

            var opcaoEscolhida = Console.ReadLine();                       
            return Convert.ToInt32(opcaoEscolhida);
        }
    }
}