using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class DETALLEFACTURA
    {
        public int CODIGODETALLE { get; set; }
        public int NUMEROFACTURA { get; set; }
        public int CODIGOPRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public double PRECIO { get; set; }
        public double DESCUENTO { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }  //Relacion de 1-1
        public virtual FACTURA FACTURA { get; set; }    //Relacion de 1-1
    }
}
