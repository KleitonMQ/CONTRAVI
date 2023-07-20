using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CONTRAVI.Entities
{
    public class Motorista
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String CPF { get; set; }
        [Required]
        public String Tell { get; set;}
        [Required]
        public int Address { get; set;}
    }
}
