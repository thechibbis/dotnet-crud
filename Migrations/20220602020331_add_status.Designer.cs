﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_test;

namespace dotnet_test.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220602020331_add_status")]
    partial class add_status
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "6.0.0-preview.5.21301.9");

            modelBuilder.Entity("dotnet_test.entities.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("senha")
                        .HasColumnType("longtext");

                    b.Property<string>("sobrenome")
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "derex1",
                            senha = "derex32-1",
                            sobrenome = "xered1"
                        },
                        new
                        {
                            id = 2,
                            nome = "derex2",
                            senha = "derex32-2",
                            sobrenome = "xered2"
                        },
                        new
                        {
                            id = 3,
                            nome = "derex3",
                            senha = "derex32-3",
                            sobrenome = "xered3"
                        },
                        new
                        {
                            id = 4,
                            nome = "derex4",
                            senha = "derex32-4",
                            sobrenome = "xered4"
                        },
                        new
                        {
                            id = 5,
                            nome = "derex5",
                            senha = "derex32-5",
                            sobrenome = "xered5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
