using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCrudMySQL.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Display(Name ="id")]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name = "nome")]
        [Column("nome")]
        public string Nome { get; set; }
    }
}
