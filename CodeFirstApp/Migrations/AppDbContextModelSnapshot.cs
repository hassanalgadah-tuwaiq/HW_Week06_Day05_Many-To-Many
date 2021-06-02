﻿// <auto-generated />
using CodeFirstApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirstApp.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Area")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("CodeFirstApp.Models.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("firstName")
                        .HasColumnType("text");

                    b.Property<string>("lasName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CodeFirstApp.Models.CustomerProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerProducts");
                });

            modelBuilder.Entity("CodeFirstApp.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<float>("price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("BranchId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CodeFirstApp.Models.Profile", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("active")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("customerID")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("customerID")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("CodeFirstApp.Models.CustomerProducts", b =>
                {
                    b.HasOne("CodeFirstApp.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstApp.Models.Product", "Branch")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirstApp.Models.Product", b =>
                {
                    b.HasOne("CodeFirstApp.Models.Branch", "Branch")
                        .WithMany("Products")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirstApp.Models.Profile", b =>
                {
                    b.HasOne("CodeFirstApp.Models.Customer", "customer")
                        .WithOne("profile")
                        .HasForeignKey("CodeFirstApp.Models.Profile", "customerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}