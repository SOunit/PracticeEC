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

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed to Users
            string usersJson = System.IO.File.ReadAllText("users.json");
            List<User> users = System.Text.Json.JsonSerializer.Deserialize<List<User>>(usersJson);
            foreach (var user in users)
            {
                modelBuilder.Entity<User>().HasData(user);
            }

        }
    }
}
