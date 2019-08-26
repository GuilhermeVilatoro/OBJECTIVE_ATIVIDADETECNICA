using System.ComponentModel.DataAnnotations;

namespace AtividadeTecnica.Application.ViewModels
{
    public sealed class ProdutoViewModel
    {
        [Required(ErrorMessage = "Preencha o nome do produto")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o valor do produto")]     
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor do produto esta do intervalo permitido!")]
        public decimal Valor { get; set; }
    }
}