using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ALCARS.Models
{
    public class Funcionario
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [Display(Name = "Nome: ")]
        public string nome { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [Display(Name = "E-mail: ")]
        public string email { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        [Display(Name = "Telefone: ")]
        public string telefone { get; set; }


    }
}
