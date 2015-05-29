using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace labouchegirlsApi.Models
{
    public class Atendente
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public string lat { get; set; }
        public string log { get; set; }

    }
}