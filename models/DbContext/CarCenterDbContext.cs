using carCenter.models.clientes;
using Microsoft.EntityFrameworkCore;

namespace carCenter.models.dbcontext
{
    public partial class CarCenterDbContext : DbContext
    {
        public CarCenterDbContext() { }

        public CarCenterDbContext(DbContextOptions<CarCenterDbContext> options) : base(options) { }

        public virtual DbSet<ClienteEntity> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
