using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ALCARS.Models
{
    public class Modelo
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [Display(Name = "Descrição: ")]
        public string descricao { get; set; }


    }
}
