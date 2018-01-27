using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.DataAccess.Model
{
    public class Platos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Facturas")]
        public ICollection<Factura> Factura { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El valor {0} es requerido")]
        [Display(Name = "Porciones")]
        public int Porciones { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string UsuarioCreacion { get; set; }

        public ICollection<Ingredientes> Ingredienteses { get; set; }
    }
}