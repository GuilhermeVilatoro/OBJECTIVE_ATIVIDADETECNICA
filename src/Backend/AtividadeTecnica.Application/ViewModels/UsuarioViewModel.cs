using System.ComponentModel.DataAnnotations;

namespace AtividadeTecnica.Application.ViewModels
{
    public sealed class UsuarioViewModel
    {
        [Required(ErrorMessage = "Preencha o nome do usuário")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [MaxLength(8, ErrorMessage = "Máximo {0} caracteres")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "CEP deve ter apenas números")]
        public string Cep { get; set; }
    }
}