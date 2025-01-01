using CafeSAS.Server.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CafeSAS.Server.Data
{
    public class AplicationDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Admin> admin { get; set; }
        public DbSet<Caja> caja { get; set; }
        public DbSet<Categorias> categorias { get; set; }
        public DbSet<Detalle_Venta> detalle_Venta { get; set; }
        public DbSet<Empleado> empleado { get; set; }
        public DbSet<Inventario> inventario { get; set; }
        public DbSet<Menu> menu { get; set; }
        public DbSet<Produccion> produccion { get; set; }
        public DbSet<Producto> producto { get; set; }
        public DbSet<Sesion> sesion { get; set; }
        public DbSet<Ventas> venta { get; set; } 
        public DbSet<Tienda> tienda { get; set; }
    }
}