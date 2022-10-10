using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ALCARS.Models
{
    public class CarroAlugado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "O campo Cliente é obrigatório.")]
        [Display(Name = "Cliente: ")]
        public Cliente cliente { get; set; }
        public int idCliente { get; set; }

        [Required(ErrorMessage = "O campo Carro é obrigatório.")]
        [Display(Name = "Carro: ")]
        public Carro carro { get; set; }
        public int idCarro { get; set; }


    }
}
