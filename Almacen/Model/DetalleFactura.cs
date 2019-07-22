using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class DetalleFactura
    {
        public int CodigoDetalle { get; set; }
        public int NumeroFactura { get; set; }
        public int CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Descuento { get; set; }
        public virtual Producto Producto { get; set; }  //Relacion de 1-1
        public virtual Factura Factura { get; set; }    //Relacion de 1-1
    }
}
