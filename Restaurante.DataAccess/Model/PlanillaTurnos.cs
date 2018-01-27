using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.DataAccess.Model
{
    public class PlanillaTurnos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Empleado Empleado { get; set; }

        [ForeignKey("Empleado")]
        public int EmpleadoId { get; set; }

        public Turno Turno { get; set; }

        [ForeignKey("Turno")]
        public int TurnoId { get; set; }

    }
}