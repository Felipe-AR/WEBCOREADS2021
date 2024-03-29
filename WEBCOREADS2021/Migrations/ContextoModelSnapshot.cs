﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBCOREADS2021.Models;

namespace WEBCOREADS2021.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Agricultor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("idade")
                        .HasColumnType("Int");

                    b.Property<string>("municipio")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("proprietario")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("id");

                    b.HasIndex("cpf")
                        .IsUnique();

                    b.ToTable("Agricultores");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Area", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("gps")
                        .HasColumnType("int");

                    b.Property<double>("hectares")
                        .HasColumnType("float");

                    b.Property<string>("municipio")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("produtorID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("produtorID");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Insumo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<double>("quantidade")
                        .HasColumnType("float");

                    b.Property<int>("tipoInsumo")
                        .HasColumnType("int");

                    b.Property<double>("valor")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Insumos");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.InsumoArea", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("areaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("data")
                        .HasColumnType("Date");

                    b.Property<int>("insumoID")
                        .HasColumnType("int");

                    b.Property<double>("quantidade")
                        .HasColumnType("Float");

                    b.Property<double>("valor")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("insumoID");

                    b.ToTable("InsumosArea");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Area", b =>
                {
                    b.HasOne("WEBCOREADS2021.Models.Dominio.Agricultor", "produtor")
                        .WithMany("areas")
                        .HasForeignKey("produtorID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("produtor");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.InsumoArea", b =>
                {
                    b.HasOne("WEBCOREADS2021.Models.Dominio.Area", "area")
                        .WithMany("insumos")
                        .HasForeignKey("id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WEBCOREADS2021.Models.Dominio.Insumo", "insumo")
                        .WithMany("areasinsumo")
                        .HasForeignKey("insumoID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("area");

                    b.Navigation("insumo");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Agricultor", b =>
                {
                    b.Navigation("areas");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Area", b =>
                {
                    b.Navigation("insumos");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Insumo", b =>
                {
                    b.Navigation("areasinsumo");
                });
#pragma warning restore 612, 618
        }
    }
}
