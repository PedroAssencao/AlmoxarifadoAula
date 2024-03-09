using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ApiAlmoxarifao.Api.Models;

namespace ApiAlmoxarifao.Api.DAL
{
    public partial class AlmoxarifadoContext : DbContext
    {
        public AlmoxarifadoContext()
        {
        }

        public AlmoxarifadoContext(DbContextOptions<AlmoxarifadoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public virtual DbSet<ItemRequisicao> ItemRequisicaos { get; set; } = null!;
        public virtual DbSet<MotivoSaidum> MotivoSaida { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;
        public virtual DbSet<Requisicao> Requisicaos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DataBase");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__categori__DD5DDDBDCE421EB6");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.DepId)
                    .HasName("PK__departam__BB4BD8F84F7A2B81");

                entity.Property(e => e.DepSituacao).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.FunId)
                    .HasName("PK__Funciona__35A47928D59F69CE");
            });

            modelBuilder.Entity<ItemRequisicao>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__ItemRequ__52020FDDE8FF6C15");

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.ItemRequisicaos)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("FK__ItemRequi__pro_i__0C85DE4D");

                entity.HasOne(d => d.Req)
                    .WithMany(p => p.ItemRequisicaos)
                    .HasForeignKey(d => d.ReqId)
                    .HasConstraintName("FK__ItemRequi__req_i__0B91BA14");
            });

            modelBuilder.Entity<MotivoSaidum>(entity =>
            {
                entity.HasKey(e => e.MotId)
                    .HasName("PK__MotivoSa__E0752241C9225504");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.MotivoSaida)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__MotivoSai__cat_i__5CD6CB2B");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.ProId)
                    .HasName("PK__produtos__335E4CA6D5258034");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__produtos__cat_id__3A81B327");
            });

            modelBuilder.Entity<Requisicao>(entity =>
            {
                entity.HasKey(e => e.ReqId)
                    .HasName("PK__requisic__1513A6FBBC4D53F0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
