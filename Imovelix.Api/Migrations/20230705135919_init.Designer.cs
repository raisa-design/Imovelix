﻿// <auto-generated />
using Imovelix.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Imovelix.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230705135919_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1");

            modelBuilder.Entity("Imovelix.Api.Entidade.Imovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Disponivel")
                        .HasColumnType("REAL");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Imoveis");
                });
#pragma warning restore 612, 618
        }
    }
}