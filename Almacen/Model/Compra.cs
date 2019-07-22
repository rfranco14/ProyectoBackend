using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public int NumeroDocumento { get; set; }
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }      //Relacion de 1-n
        public virtual Proveedor Proveedor { get; set; }                            //Relacion de 1-1
    }
}
