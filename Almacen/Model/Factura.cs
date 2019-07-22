using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class Factura
    {
        public int NumeroFactura { get; set; }
        public string Nit { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public virtual ICollection<DetalleFactura>DetalleFacturas { get; set; } //Relacion de 1-n
        public virtual Cliente Cliente { get; set; }                            //Relacion de 1-1
    }
}
