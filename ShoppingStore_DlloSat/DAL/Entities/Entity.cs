using System.ComponentModel.DataAnnotations;

namespace ShoppingStore_DlloSat.DAL.Entities
{
    public class Entity
    {
        [Required] //REQUERIDO OBLIGATORIO
        public Guid Id { get; set; } //PK
        
        [Display (Name = "Fecha de creación")] //Para mostrar el nombre que quiero en las vistas
        public DateTime? CreatedDate { get; set; } //(?) S.Elvis, CAMPO NULLEABLE
        
        [Display(Name = "Fecha de Modificación")]
        public DateTime? ModifiedDate { get; set; }
    }
}
