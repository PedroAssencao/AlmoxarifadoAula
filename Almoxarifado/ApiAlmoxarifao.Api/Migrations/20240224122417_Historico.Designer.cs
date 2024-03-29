﻿// <auto-generated />
using System;
using ApiAlmoxarifao.Api.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiAlmoxarifao.Api.Migrations
{
    [DbContext(typeof(AlmoxarifadoContext))]
    [Migration("20240224122417_Historico")]
    partial class Historico
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.Historico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int>("ProdutoNavigationProId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoNavigationProId");

                    b.ToTable("Historico");
                });

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.Produto", b =>
                {
                    b.Property<int>("ProId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("pro_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProId"), 1L, 1);

                    b.Property<int?>("ProEstoque")
                        .HasColumnType("int")
                        .HasColumnName("pro_estoque");

                    b.Property<string>("ProImg")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("pro_img");

                    b.Property<string>("ProNome")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("pro_nome");

                    b.HasKey("ProId")
                        .HasName("PK__produtos__335E4CA6D5258034");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.Historico", b =>
                {
                    b.HasOne("ApiAlmoxarifao.Api.Models.Produto", "ProdutoNavigation")
                        .WithMany("Historico")
                        .HasForeignKey("ProdutoNavigationProId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProdutoNavigation");
                });

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.Produto", b =>
                {
                    b.Navigation("Historico");
                });
#pragma warning restore 612, 618
        }
    }
}
