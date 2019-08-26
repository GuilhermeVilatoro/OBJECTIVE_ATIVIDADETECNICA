using System.ComponentModel.DataAnnotations;

namespace AtividadeTecnica.Application.ViewModels
{
    public sealed class ProdutoCarrinhoViewModel
    {
        public ProdutoCarrinhoViewModel()
        {
            Produto = new ProdutoViewModel();
        }

        [Required(ErrorMessage = "Preencha a quantidade do produto")]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade esta fora do intervalo permitido!")]
        public int Quantidade { get; set; }

        public ProdutoViewModel Produto { get; set; }
    }
}