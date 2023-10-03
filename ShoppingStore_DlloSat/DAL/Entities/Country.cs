using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShoppingStore_DlloSat.DAL.Entities
{
    //PRIMERA ENTIDAD EN CONVERTIRSE EN TABLA EN LA DB
    public class Country : Entity
    {
        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage ="El Campo {0} debe de tener maximo {1} caracteres. ")] //Campo País maximo 50 caracteres  
        [Required(ErrorMessage ="¡El campo País {0} es requerido!")]
        public string Name { get; set; }
    }
}
