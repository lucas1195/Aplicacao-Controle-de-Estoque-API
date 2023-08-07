namespace APIControleEstoque.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public int Preco { get; set; }

        public int Quantidade { get; set; }

        public string? Categoria { get; set; }

    }
}