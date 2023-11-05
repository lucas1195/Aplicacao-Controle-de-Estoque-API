using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIControleEstoque.Models
{
    [Table("Produto")]
    public class Produto 
    {
        [Key]
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public int Preco { get; set; }

        public int Quantidade { get; set; }

        public string? Categoria { get; set; }

    }
}