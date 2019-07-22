using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class COMPRA
    {
        public int IDCOMPRA { get; set; }
        public int NUMERODOCUMENTO { get; set; }
        public int CODIGOPROVEEDOR { get; set; }
        public DateTime FECHA { get; set; }
        public decimal TOTAL { get; set; }
        public virtual ICollection<DETALLECOMPRA> DETALLECOMPRAS { get; set; }      //Relacion de 1-n
        public virtual PROVEEDOR PROVEEDOR { get; set; }                            //Relacion de 1-1
    }
}
