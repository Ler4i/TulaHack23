﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data.Identity;

namespace WebAppAutorization.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {        
        }


           
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().Property(z => z.Id).UseIdentityColumn();
            builder.Entity<User>().Property(z => z.Name).HasMaxLength(100);
            builder.Entity<User>().Property(z => z.Role).HasMaxLength(20);

            builder.Entity<Message>().Property(z => z.Id).UseIdentityColumn();
            builder.Entity<Message>().Property(z => z.Heading).HasMaxLength(25);
            builder.Entity<Message>().Property(z => z.Text).HasMaxLength(270);

            builder.Entity<User>().HasData(
                new User
                {
                    Id=1,
                    Name="First",
                    Role="пользователь"
                });

            builder.Entity<Message>().HasData(
                new Message
                {
                    Id = 1,
                    Heading = "First",
                    Text = "Привет"
                });

            base.OnModelCreating(builder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}