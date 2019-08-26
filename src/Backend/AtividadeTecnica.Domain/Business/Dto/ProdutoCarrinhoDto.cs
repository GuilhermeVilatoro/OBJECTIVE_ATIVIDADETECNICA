namespace AtividadeTecnica.Domain.Business.Dto
{
    public sealed class ProdutoCarrinhoDto
    {
        public ProdutoCarrinhoDto()
        {
            Produto = new ProdutoDto();
        }

        public int Quantidade { get; set; }

        public ProdutoDto Produto { get; set; }
    }
}