using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.DataAccess.Model
{
    public class Ingredientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [DisplayName("Ingrediente")]
        public string Nombre{ get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [DisplayName("Ingrediente")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Platos")]
        public ICollection<Platos> Platos { get; set; } 

    }
}