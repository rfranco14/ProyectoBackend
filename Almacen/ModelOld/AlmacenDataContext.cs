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
        public DbSet<CATEGORIA> CATEGORIAS { get; set; }
        public DbSet<CLIENTE> CLIENTES { get; set; }
        public DbSet< COMPRA > COMPRAS { get; set; }
        public DbSet< DETALLECOMPRA > DETALLECOMPRAS { get; set; }
        public DbSet< DETALLEFACTURA > DETALLEFACTURAS { get; set; }
        public DbSet< EMAILCLIENTE > EMAILCLIENTES { get; set; }
        public DbSet< EMAILPROVEEDOR > EMAILPROVEEDORS { get; set; }
        public DbSet< FACTURA > FACTURAS { get; set; }
        public DbSet< INVENTARIO > INVENTARIOS { get; set; }
        public DbSet< PRODUCTO > PRODUCTOS { get; set; }
        public DbSet< PROVEEDOR > PROVEEDORS { get; set; }
        public DbSet< TELEFONOCLIENTE > TELEFONOCLIENTES { get; set; }
        public DbSet< TELEFONOPROVEEDOR > TELEFONOPROVEEDORS { get; set; }
        public DbSet< TIPOEMPAQUE > TIPOEMPAQUES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            //----------------------------------------------------------------
            modelBuilder.Entity<CATEGORIA>()
                .ToTable("CATEGORIA")
                .HasKey(c => new { c.CODIGOCATEGORIA });

            //----------------------------------------------------------------
            modelBuilder.Entity<CLIENTE>()
                .ToTable("CLIENTE")
                .HasKey(c => new { c.NIT });

            //----------------------------------------------------------------
            modelBuilder.Entity<COMPRA>()
                .ToTable("COMPRA")
                .HasKey(c => new { c.IDCOMPRA });

            //----------------------------------------------------------------
            modelBuilder.Entity<DETALLECOMPRA>()
                .ToTable("DETALLECOMPRA")
                .HasKey(d => new { d.IDDETALLE });

            //----------------------------------------------------------------
            modelBuilder.Entity<DETALLEFACTURA>()
                .ToTable("DETALLEFACTURA")
                .HasKey(d => new { d.CODIGODETALLE });

            //----------------------------------------------------------------
            modelBuilder.Entity<EMAILCLIENTE>()
                .ToTable("EMAILCLIENTE")
                .HasKey(e => new { e.CODIGOEMAIL });

            //----------------------------------------------------------------
            modelBuilder.Entity<EMAILPROVEEDOR>()
                .ToTable("EMAILPROVEEDOR")
                .HasKey(e => new { e.CODIGOEMAIL });

            //----------------------------------------------------------------
            modelBuilder.Entity<FACTURA>()
                .ToTable("FACTURA")
                .HasKey(f => new { f.NUMEROFACTURA });

            //----------------------------------------------------------------
            modelBuilder.Entity<INVENTARIO>()
                .ToTable("INVENTARIO")
                .HasKey(i => new { i.CODIGOINVENTARIO });

            //----------------------------------------------------------------
            modelBuilder.Entity<PRODUCTO>()
                .ToTable("PRODUCTO")
                .HasKey(p => new { p.CODIGOPRODUCTO });

            //----------------------------------------------------------------
            modelBuilder.Entity<PROVEEDOR>()
                .ToTable("PROVEEDOR")
                .HasKey(p => new { p.CODIGOPROVEEDOR });

            //----------------------------------------------------------------
            modelBuilder.Entity<TELEFONOCLIENTE>()
                .ToTable("TELEFONOCLIENTE")
                .HasKey(t => new { t.CODIGOTELEFONO });

            //----------------------------------------------------------------
            modelBuilder.Entity<TELEFONOPROVEEDOR>()
                .ToTable("TELEFONOPROVEEDOR")
                .HasKey(t => new { t.CODIGOTELEFONO });

            //----------------------------------------------------------------
            modelBuilder.Entity<TIPOEMPAQUE>()
                .ToTable("TIPOEMPAQUE")
                .HasKey(t => new { t.CODIGOEMPAQUE });
        }

    }
}
