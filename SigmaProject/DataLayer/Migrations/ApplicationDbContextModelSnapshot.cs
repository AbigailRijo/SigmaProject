﻿// <auto-generated />
using System;
using DataLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByUser")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<string>("ModifyedByUser")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ModifyedDate");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2019, 6, 1, 10, 32, 20, 911, DateTimeKind.Local).AddTicks(1438),
                            FirstName = "Admin",
                            IsDeleted = false,
                            LastName = "Admin",
                            ModifyedDate = new DateTime(2019, 6, 1, 10, 32, 20, 912, DateTimeKind.Local).AddTicks(6580),
                            Password = "LY2TluXFMaUK7hjiqR+E+VQjU43eWO0v7Pl6wXvrNOc=",
                            Username = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
