using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.DataAccess.Model
{
    public class Factura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Mesero")]
        public Empleado Mesero { get; set; }

        [ForeignKey("Mesero")]
        public int MeseroId { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Mesa")]
        public int Mesa { get; set; }

        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
    }
}