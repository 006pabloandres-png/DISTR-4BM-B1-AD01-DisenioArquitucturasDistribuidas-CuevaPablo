using Inventario.Api.Models;
using InventarioDB2.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Api.Data
{
    public class InventarioDbContext : DbContext
    {
        public InventarioDbContext(DbContextOptions<InventarioDbContext> options) : base(options)
        {
        }

        public DbSet<Bodega> Bodegas { get; set; }
        public DbSet<Existencia> Existencias { get; set; }
        public DbSet<MovimientoInventario> Movimientos { get; set; }
        public DbSet<ReservaStock> Reservas { get; set; }
    }
}
