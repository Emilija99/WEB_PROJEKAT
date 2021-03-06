﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekat_Backend.Models;

namespace Projekat_Backend.Migrations
{
    [DbContext(typeof(ProjekatContext))]
    partial class ProjekatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Projekat_Backend.Models.Kolekcija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Naslov");

                    b.HasKey("ID");

                    b.ToTable("Kolekcija");
                });

            modelBuilder.Entity("Projekat_Backend.Models.Lista", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int?>("KolekcijaRefID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Naziv");

                    b.HasKey("ID");

                    b.HasIndex("KolekcijaRefID");

                    b.ToTable("Lista");
                });

            modelBuilder.Entity("Projekat_Backend.Models.MojaBeleska", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DatumModifikacije")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KolekcijaRefID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KolekcijaRefID");

                    b.ToTable("MojaBeleska");
                });

            modelBuilder.Entity("Projekat_Backend.Models.Stavka", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int>("ListaRefID")
                        .HasColumnType("int");

                    b.Property<string>("Podatak")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Podatak");

                    b.HasKey("ID");

                    b.HasIndex("ListaRefID");

                    b.ToTable("Stavka");
                });

            modelBuilder.Entity("Projekat_Backend.Models.Lista", b =>
                {
                    b.HasOne("Projekat_Backend.Models.Kolekcija", "KolekcijaRef")
                        .WithMany("Liste")
                        .HasForeignKey("KolekcijaRefID");

                    b.Navigation("KolekcijaRef");
                });

            modelBuilder.Entity("Projekat_Backend.Models.MojaBeleska", b =>
                {
                    b.HasOne("Projekat_Backend.Models.Kolekcija", "KolekcijaRef")
                        .WithMany("Beleske")
                        .HasForeignKey("KolekcijaRefID");

                    b.Navigation("KolekcijaRef");
                });

            modelBuilder.Entity("Projekat_Backend.Models.Stavka", b =>
                {
                    b.HasOne("Projekat_Backend.Models.Lista", "ListaRef")
                        .WithMany("ListaStavki")
                        .HasForeignKey("ListaRefID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListaRef");
                });

            modelBuilder.Entity("Projekat_Backend.Models.Kolekcija", b =>
                {
                    b.Navigation("Beleske");

                    b.Navigation("Liste");
                });

            modelBuilder.Entity("Projekat_Backend.Models.Lista", b =>
                {
                    b.Navigation("ListaStavki");
                });
#pragma warning restore 612, 618
        }
    }
}
