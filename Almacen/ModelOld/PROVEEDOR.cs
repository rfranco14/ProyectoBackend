using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class PROVEEDOR
    {
        public int CODIGOPROVEEDOR { get; set; }
        public string NIT { get; set; }
        public string RAZONSOCIAL { get; set; }
        public string DIRECCION { get; set; }
        public string PAGINAWEB { get; set; }
        public string CONTACTOPRINCIPAL { get; set; }
        public virtual ICollection<COMPRA>COMPRAS { get; set; }                         //Relacion de 1-n
        public virtual ICollection<EMAILPROVEEDOR> EMAILPROVEEDORS { get; set; }        //Relacion de 1-n
        public virtual ICollection<TELEFONOPROVEEDOR>TELEFONOPROVEEDORS { get; set; }   //Relacion de 1-n
    }
}
