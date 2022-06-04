﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoAula.Models;

namespace ProyectoAula.Migrations
{
    [DbContext(typeof(ContextoBD))]
    partial class ContextoBDModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectoAula.Models.DetalleCompra", b =>
                {
                    b.Property<int>("DetalleCompra_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<float>("PrecioCompra")
                        .HasColumnType("real");

                    b.Property<float>("PrecioVenta")
                        .HasColumnType("real");

                    b.Property<int>("Producto_ID")
                        .HasColumnType("int");

                    b.Property<int>("Proveedores_ID")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("DetalleCompra_ID");

                    b.HasIndex("Producto_ID");

                    b.HasIndex("Proveedores_ID");

                    b.ToTable("DetalleCompra");
                });

            modelBuilder.Entity("ProyectoAula.Models.DetalleVenta", b =>
                {
                    b.Property<int>("DetalleVenta_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime2");

                    b.Property<float>("PrecioVenta")
                        .HasColumnType("real");

                    b.Property<int>("Producto_ID")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("DetalleVenta_ID");

                    b.HasIndex("Producto_ID");

                    b.ToTable("DetalleVentas");
                });

            modelBuilder.Entity("ProyectoAula.Models.Productos", b =>
                {
                    b.Property<int>("Producto_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Division")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<float>("Precio_Compra")
                        .HasColumnType("real");

                    b.Property<float>("Precio_Venta")
                        .HasColumnType("real");

                    b.Property<string>("Producto_Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<float>("Talla")
                        .HasColumnType("real");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("Producto_ID");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("ProyectoAula.Models.Proveedores", b =>
                {
                    b.Property<int>("Proveedores_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Proveedores_ID");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("ProyectoAula.Models.Usuario", b =>
                {
                    b.Property<int>("Usuario_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Roles")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Usuario_ID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoAula.Models.DetalleCompra", b =>
                {
                    b.HasOne("ProyectoAula.Models.Productos", "Productos")
                        .WithMany()
                        .HasForeignKey("Producto_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoAula.Models.Proveedores", "Proveedores")
                        .WithMany()
                        .HasForeignKey("Proveedores_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProyectoAula.Models.DetalleVenta", b =>
                {
                    b.HasOne("ProyectoAula.Models.Productos", "Productos")
                        .WithMany()
                        .HasForeignKey("Producto_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
