using System.Collections.Generic;

namespace AtividadeTecnica.Application.ViewModels
{
    public sealed class CarrinhoViewModel
    {
        public CarrinhoViewModel()
        {
            Usuario = new UsuarioViewModel();
            ProdutosCarrinho = new List<ProdutoCarrinhoViewModel>();
        }

        public UsuarioViewModel Usuario { get; set; }

        public IEnumerable<ProdutoCarrinhoViewModel> ProdutosCarrinho { get; set; }
    }
}