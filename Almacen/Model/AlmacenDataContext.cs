using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class AlmacenDataContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet< Compra > Compras { get; set; }
        public DbSet< DetalleCompra > DetalleCompras { get; set; }
        public DbSet< DetalleFactura > DetalleFacturas { get; set; }
        public DbSet< EmailCliente > EmailClientes { get; set; }
        public DbSet< EmailProveedor > EmailProveedores { get; set; }
        public DbSet< Factura > Facturas { get; set; }
        public DbSet< Inventario > Inventarios { get; set; }
        public DbSet< Producto > Productos { get; set; }
        public DbSet< Proveedor > Proveedores { get; set; }
        public DbSet< TelefonoCliente > TelefonoClientes { get; set; }
        public DbSet< TelefonoProveedor > TelefonoProveedores { get; set; }
        public DbSet< TipoEmpaque > TipoEmpaques { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            //----------------------------------------------------------------
            modelBuilder.Entity<Categoria>()
                .ToTable("Categoria")
                .HasKey(c => new { c.CodigoCategoria });

            //----------------------------------------------------------------
            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
                .HasKey(c => new { c.Nit });

            //----------------------------------------------------------------
            modelBuilder.Entity<Compra>()
                .ToTable("Compra")
                .HasKey(c => new { c.IdCompra });

            //----------------------------------------------------------------
            modelBuilder.Entity<DetalleCompra>()
                .ToTable("DetalleCompra")
                .HasKey(d => new { d.IdDetalle });

            //----------------------------------------------------------------
            modelBuilder.Entity<DetalleFactura>()
                .ToTable("DetalleFactura")
                .HasKey(d => new { d.CodigoDetalle });

            //----------------------------------------------------------------
            modelBuilder.Entity<EmailCliente>()
                .ToTable("EmailCliente")
                .HasKey(e => new { e.CodigoEmail });

            //----------------------------------------------------------------
            modelBuilder.Entity<EmailProveedor>()
                .ToTable("EmailProveedor")
                .HasKey(e => new { e.CodigoEmail });

            //----------------------------------------------------------------
            modelBuilder.Entity<Factura>()
                .ToTable("Factura")
                .HasKey(f => new { f.NumeroFactura });

            //----------------------------------------------------------------
            modelBuilder.Entity<Inventario>()
                .ToTable("Inventario")
                .HasKey(i => new { i.CodigoInventario });

            //----------------------------------------------------------------
            modelBuilder.Entity<Producto>()
                .ToTable("Producto")
                .HasKey(p => new { p.CodigoProducto });

            //----------------------------------------------------------------
            modelBuilder.Entity<Proveedor>()
                .ToTable("Proveedor")
                .HasKey(p => new { p.CodigoProveedor });

            //----------------------------------------------------------------
            modelBuilder.Entity<TelefonoCliente>()
                .ToTable("TelefonoCliente")
                .HasKey(t => new { t.CodigoTelefono });

            //----------------------------------------------------------------
            modelBuilder.Entity<TelefonoProveedor>()
                .ToTable("TelefonoProveedor")
                .HasKey(t => new { t.CodigoTelefono });

            //----------------------------------------------------------------
            modelBuilder.Entity<TipoEmpaque>()
                .ToTable("TipoEmpaque")
                .HasKey(t => new { t.CodigoEmpaque });
        }

    }
}
