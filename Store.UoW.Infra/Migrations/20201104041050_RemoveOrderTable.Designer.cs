﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.UoW.Infra.Context;

namespace Store.UoW.Infra.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20201104041050_RemoveOrderTable")]
    partial class RemoveOrderTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Store.UoW.Domain.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("VARCHAR(90)")
                        .HasMaxLength(90);

                    b.Property<decimal>("Price")
                        .HasColumnName("price")
                        .HasColumnType("DECIMAL");

                    b.Property<int>("Stock")
                        .HasColumnName("stock")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.ToTable("Products","dbo");
                });
#pragma warning restore 612, 618
        }
    }
}