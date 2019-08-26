using System.Collections.Generic;

namespace AtividadeTecnica.Domain.Business.Dto
{
    public sealed class CarrinhoDto
    {
        public CarrinhoDto()
        {
            Usuario = new UsuarioDto();
            ProdutosCarrinho = new List<ProdutoCarrinhoDto>();
        }

        public UsuarioDto Usuario { get; set; }

        public IEnumerable<ProdutoCarrinhoDto> ProdutosCarrinho { get; set; }
    }
}