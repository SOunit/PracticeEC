using Entities.IdentityEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        //options from program.cs is supplied here in contructor and base class contructor
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed to Users
            string productsJson = System.IO.File.ReadAllText("products.json");
            List<Product> products = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(productsJson);
            foreach (var product in products)
            {
                modelBuilder.Entity<Product>().HasData(product);
            }

        }
    }
}
