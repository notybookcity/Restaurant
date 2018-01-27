using Microsoft.AspNet.Identity.EntityFramework;
using Restaurant.UI.Models;
using Restaurante.DataAccess.Model;

namespace Restaurante.DataAccess
{
    public class RestaurantContext : IdentityDbContext<ApplicationUser>
    {
        public RestaurantContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Sucursal> Sucursals { get; set; }

        public System.Data.Entity.DbSet<Cargo> Cargoes { get; set; }

        public System.Data.Entity.DbSet<Ingredientes> Ingredientes { get; set; }

        public System.Data.Entity.DbSet<Platos> Platos { get; set; }

        public System.Data.Entity.DbSet<Carta> Cartas { get; set; }

        public System.Data.Entity.DbSet<Empleado> Empleadoes { get; set; }

        public System.Data.Entity.DbSet<Factura> Facturas { get; set; }

        public System.Data.Entity.DbSet<Pagos> Pagos { get; set; }

        public System.Data.Entity.DbSet<Turno> Turnoes { get; set; }

        public System.Data.Entity.DbSet<PlanillaTurnos> PlanillaTurnos { get; set; }
    }
}
