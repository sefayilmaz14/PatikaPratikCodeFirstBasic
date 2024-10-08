using Microsoft.EntityFrameworkCore;
using PatikaPratikCodeFirstBasic.Entites;

namespace PatikaPratikCodeFirstBasic.Context
{
    public class PatikaFirstDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"server=HAZAL; database=PatikaCodeFirstDb1; TrustServerCertificate=true; trusted_connection = true;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<MovieEntity> Movies => Set<MovieEntity>();
        public DbSet<GameEntity> Games => Set<GameEntity>();

    }
}
