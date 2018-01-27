using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.DataAccess.Model
{
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        public Cargo Cargo { get; set; }

        [ForeignKey("Cargo")]
        public int CargoId { get; set; }

        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
    }
}