using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class FACTURA
    {
        public int NUMEROFACTURA { get; set; }
        public string NIT { get; set; }
        public DateTime FECHA { get; set; }
        public double TOTAL { get; set; }
        public virtual ICollection<DETALLEFACTURA>DETALLEFACTURAS { get; set; } //Relacion de 1-n
        public virtual CLIENTE CLIENTE { get; set; }                            //Relacion de 1-1
    }
}
