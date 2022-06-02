using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using dotnet_test.entities;

namespace dotnet_test
{
    public partial class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.nome).HasMaxLength(20);
            modelBuilder.Entity<User>().HasIndex(u => u.sobrenome).IsUnique();

            modelBuilder.Entity<User>().HasData(
                new User {id=1, nome="derex1", sobrenome="xered1", email="email@email.com1", senha="derex32-1", status="on"},
                new User {id=2, nome="derex2", sobrenome="xered2", email="email@email.com2", senha="derex32-2", status="on"},
                new User {id=3, nome="derex3", sobrenome="xered3", email="email@email.com3", senha="derex32-3", status="on"},
                new User {id=4, nome="derex4", sobrenome="xered4", email="email@email.com4", senha="derex32-4", status="on"},
                new User {id=5, nome="derex5", sobrenome="xered5", email="email@email.com5", senha="derex32-5", status="on"},
                new User {id=6, nome="derex6", sobrenome="xered6", email="email@email.com6", senha="derex32-6", status="on"}
            );

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
