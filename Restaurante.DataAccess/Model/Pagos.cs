using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.DataAccess.Model
{
    public class Pagos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Factura")]
        public Factura Factura { get; set; }

        [ForeignKey("Factura")]
        public int FacturaId { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Propina")]
        public decimal Propina { get; set; }

        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
    }
}