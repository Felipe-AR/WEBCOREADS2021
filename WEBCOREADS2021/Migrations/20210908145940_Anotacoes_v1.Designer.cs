﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBCOREADS2021.Models;

namespace WEBCOREADS2021.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210908145940_Anotacoes_v1")]
    partial class Anotacoes_v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("proprietario")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("id");

                    b.ToTable("Agricultor");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Area", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gps")
                        .HasColumnType("int");

                    b.Property<float>("hectares")
                        .HasColumnType("real");

                    b.Property<string>("municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("produtorid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("produtorid");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Insumo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("quantidade")
                        .HasColumnType("real");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Insumos");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.InsumoArea", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("areaid")
                        .HasColumnType("int");

                    b.Property<int?>("insumoid")
                        .HasColumnType("int");

                    b.Property<float>("quantidade")
                        .HasColumnType("real");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("areaid");

                    b.HasIndex("insumoid");

                    b.ToTable("InsumosArea");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Area", b =>
                {
                    b.HasOne("WEBCOREADS2021.Models.Dominio.Agricultor", "produtor")
                        .WithMany("areas")
                        .HasForeignKey("produtorid");

                    b.Navigation("produtor");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.InsumoArea", b =>
                {
                    b.HasOne("WEBCOREADS2021.Models.Dominio.Area", "area")
                        .WithMany("insumos")
                        .HasForeignKey("areaid");

                    b.HasOne("WEBCOREADS2021.Models.Dominio.Insumo", "insumo")
                        .WithMany("areas")
                        .HasForeignKey("insumoid");

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
                    b.Navigation("areas");
                });
#pragma warning restore 612, 618
        }
    }
}