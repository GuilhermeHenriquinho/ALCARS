using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ALCARS.Models
{
    public class Carro
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "O campo Placa é obrigatório.")]
        [Display(Name = "Placa: ")]
        public string placa { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "O campo Ano é obrigatório.")]
        [Display(Name = "Ano: ")]
        public DateTime ano { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "O campo KM rodado é obrigatório.")]
        [Display(Name = "KM Rodado: ")]
        public DateTime kmRodado { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "O campo é obrigatório.")]
        [Display(Name = "É usado?: ")]
        public Boolean usado { get; set; }

        [Required(ErrorMessage = "O campo Modelo é obrigatório.")]
        [Display(Name = "Modelo: ")]
        public Modelo modelo { get; set; }
        public int idModelo { get; set; }




    }
}
