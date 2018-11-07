﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductCatalog.DataAccess;

namespace ProductCatalog.API.Migrations
{
    [DbContext(typeof(ProductCatalogContext))]
    [Migration("20181103174816_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductCatalog.DataAccess.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Image");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("ProductPrice");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductName")
                        .IsUnique();

                    b.ToTable("product");

                    b.HasData(
                        new { ProductId = 1, Image = new byte[] { 84, 101, 115, 116 }, LastUpdated = new DateTime(2018, 11, 3, 13, 48, 15, 886, DateTimeKind.Local), ProductName = "Sample Product", ProductPrice = 10 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
