using Microsoft.EntityFrameworkCore;

namespace BackEnd.Model
{
    public class MiContexto : DbContext
    {
        public MiContexto(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
    }
}
