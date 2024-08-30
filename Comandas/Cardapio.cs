using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comandas
{
    public class Cardapio
    {
        public Cardapio()
        {
        }
        [Key] // Chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descrição { get; set; }
        public decimal Preço { get; set; }
        public bool PossuiPreparo { get; set; }
    }
}