using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppAutority.Data.Identity;

namespace WebAppAutority.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>().Property(z => z.Id).UseIdentityColumn();
            builder.Entity<Client>().Property(z => z.Name).HasMaxLength(50);
            builder.Entity<Client>().Property(z => z.Post).HasMaxLength(50);
            builder.Entity<Client>().Property(z => z.Email).HasMaxLength(15);

            builder.Entity<Client>().HasData(
                new Client
                {
                    Id=1,
                    Name= "First",
                    Post= "Director",
                    Email=""
                });

            base.OnModelCreating(builder);
        }

        public DbSet<Client> Clients { get; set; } 
    }
}