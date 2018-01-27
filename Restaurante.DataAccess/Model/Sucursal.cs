using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.DataAccess.Model
{
    public class Sucursal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Nombre de la sucursal")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Dirección de la sucursal")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Contacto de la sucursal")]
        public string Contacto { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Horario de la sucursal")]
        public string Horario { get; set; }

        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
    }
}