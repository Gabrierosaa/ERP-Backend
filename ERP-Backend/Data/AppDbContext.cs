using ERP_Backend.Entities;
using ERP_Backend.Entities.Customer;
using ERP_Backend.Entities.Product;
using Microsoft.EntityFrameworkCore;

namespace ERP_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        // Só os DbSet que vão receber resultado de SELECT/proc
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mínimo necessário só para mapear tabela/colunas se quiser
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Product>().ToTable("Products");
        }
    }
}