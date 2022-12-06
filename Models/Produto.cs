using System.ComponentModel.DataAnnotations;

namespace ProvaCSharp.Models
{
    public class Produto
    {
        [Key]
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
