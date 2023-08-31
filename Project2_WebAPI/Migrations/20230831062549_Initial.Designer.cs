﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project2_WebAPI.Model;

#nullable disable

namespace Project2_WebAPI.Migrations
{
    [DbContext(typeof(cmpg323dbContext))]
    [Migration("20230831062549_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Project2_WebAPI.Model.Customer", b =>
                {
                    b.Property<short>("CustomerId")
                        .HasColumnType("smallint");

                    b.Property<string>("CellPhone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerSurname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerTitle")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Project2_WebAPI.Model.Order", b =>
                {
                    b.Property<short>("OrderId")
                        .HasColumnType("smallint");

                    b.Property<short>("CustomerId")
                        .HasColumnType("smallint");

                    b.Property<string>("DeliveryAddress")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Project2_WebAPI.Model.OrderDetail", b =>
                {
                    b.Property<short>("OrderDetailsId")
                        .HasColumnType("smallint")
                        .HasColumnName("OrderDetailsID");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<short>("OrderId")
                        .HasColumnType("smallint");

                    b.Property<short>("ProductId")
                        .HasColumnType("smallint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Project2_WebAPI.Model.Product", b =>
                {
                    b.Property<short>("ProductId")
                        .HasColumnType("smallint");

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Project2_WebAPI.Model.Order", b =>
                {
                    b.HasOne("Project2_WebAPI.Model.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_Orders_Customers");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Project2_WebAPI.Model.OrderDetail", b =>
                {
                    b.HasOne("Project2_WebAPI.Model.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Orders");

                    b.HasOne("Project2_WebAPI.Model.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Products1");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Project2_WebAPI.Model.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Project2_WebAPI.Model.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Project2_WebAPI.Model.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}