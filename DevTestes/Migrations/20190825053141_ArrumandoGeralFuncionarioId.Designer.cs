﻿// <auto-generated />
using System;
using DevTestes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DevTestes.Migrations
{
    [DbContext(typeof(DevTestesContext))]
    [Migration("20190825053141_ArrumandoGeralFuncionarioId")]
    partial class ArrumandoGeralFuncionarioId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DevTestes.Models.BugProblema", b =>
                {
                    b.Property<int>("BugProblemaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Chamado")
                        .IsRequired()
                        .HasColumnType("varchar(6)");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<DateTime>("DtaComplemento");

                    b.Property<int>("FuncionarioId");

                    b.Property<string>("Impacto")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("SprintId");

                    b.HasKey("BugProblemaId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("SprintId");

                    b.ToTable("BugProblemas");
                });

            modelBuilder.Entity("DevTestes.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnName("varchar(30)");

                    b.HasKey("FuncionarioId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("DevTestes.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnName("varchar(20)");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("DevTestes.Models.Sprint", b =>
                {
                    b.Property<int>("SprintId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeSprint")
                        .IsRequired()
                        .HasColumnName("varchar(20)");

                    b.HasKey("SprintId");

                    b.ToTable("Sprints");
                });

            modelBuilder.Entity("DevTestes.Models.BugProblema", b =>
                {
                    b.HasOne("DevTestes.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DevTestes.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DevTestes.Models.Sprint", "Sprint")
                        .WithMany()
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
