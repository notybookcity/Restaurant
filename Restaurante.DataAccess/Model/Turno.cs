using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.DataAccess.Model
{
    public class Turno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Hora de inicio")]
        public string HoraInicio { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Hora final")]
        public string HoraFin { get; set; }

        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }

    }
}