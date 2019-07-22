using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class CLIENTE
    {
        public string NIT { get; set; }
        public string DPI { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public virtual ICollection<FACTURA>FACTURAS { get; set; }                   //Relacion de 1-n
        public virtual ICollection<EMAILCLIENTE>EMAILCLIENTES { get; set; }         //Relacion de 1-n
        public virtual ICollection<TELEFONOCLIENTE>TELEFONOCLIENTES { get; set; }   //Relacion de 1-n
    }
}
