﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIFaseA.DataSource;

#nullable disable

namespace WebAPIFaseA.Migrations
{
    [DbContext(typeof(ProvaAContext))]
    partial class ProvaAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPIFaseA.Entities.Carrello", b =>
                {
                    b.Property<int>("IdCarrello")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCarrello"));

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdProdotto")
                        .HasColumnType("int");

                    b.Property<double>("PrezzoProdotto")
                        .HasColumnType("float");

                    b.Property<int>("QuantitaProdotto")
                        .HasColumnType("int");

                    b.HasKey("IdCarrello");

                    b.ToTable("Carrelli");
                });

            modelBuilder.Entity("WebAPIFaseA.Entities.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDiNascita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passward")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clienti");
                });

            modelBuilder.Entity("WebAPIFaseA.Entities.Prodotto", b =>
                {
                    b.Property<int>("IdProdotto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProdotto"));

                    b.Property<int>("Giacenza")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prezzo")
                        .HasColumnType("float");

                    b.HasKey("IdProdotto");

                    b.ToTable("Prodotti");
                });
#pragma warning restore 612, 618
        }
    }
}
