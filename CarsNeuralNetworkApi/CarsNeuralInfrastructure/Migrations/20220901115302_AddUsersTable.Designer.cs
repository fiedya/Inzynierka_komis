﻿// <auto-generated />
using CarsNeuralInfrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarsNeuralInfrastructure.Migrations
{
    [DbContext(typeof(CarsNeuralDbContext))]
    [Migration("20220901115302_AddUsersTable")]
    partial class AddUsersTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarsNeuralInfrastructure.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CarsNeuralInfrastructure.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Capacity")
                        .HasColumnType("float");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<string>("DriveType")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("GearboxType")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductionYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
