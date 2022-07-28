﻿// <auto-generated />
using System;
using CSharpIntermediate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSharpIntermediate.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CSharpIntermediate.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)")
                        .HasColumnName("id");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int(10)")
                        .HasColumnName("category_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("name")
                        .UseCollation("utf8mb4_general_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("Name"), "utf8mb4");

                    b.Property<int>("QuantityOnHand")
                        .HasColumnType("int(10)")
                        .HasColumnName("qoh");

                    b.Property<int?>("ReorderTheshold")
                        .HasColumnType("int(10)")
                        .HasColumnName("reorderthreshold");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("saleprice");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("product");
                });

            modelBuilder.Entity("CSharpIntermediate.Models.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("name");

                    b.HasKey("ProductCategoryID");

                    b.ToTable("product_category");
                });

            modelBuilder.Entity("CSharpIntermediate.Models.Product", b =>
                {
                    b.HasOne("CSharpIntermediate.Models.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("CSharpIntermediate.Models.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
