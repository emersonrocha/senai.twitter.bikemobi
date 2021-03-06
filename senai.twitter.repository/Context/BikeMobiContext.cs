using Microsoft.EntityFrameworkCore;
using senai.twitter.domain.Entities;

namespace senai.twitter.repository.Context
{
    public class BikeMobiContext : DbContext
    {
        public BikeMobiContext(DbContextOptions<BikeMobiContext> options) : base(options) { }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Perfil> Perfis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>().ToTable("Logins");
            modelBuilder.Entity<Perfil>().ToTable("Perfis");

            base.OnModelCreating(modelBuilder);
        }
    }
}