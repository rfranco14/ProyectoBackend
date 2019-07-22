using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class TELEFONOPROVEEDOR
    {
        public int CODIGOTELEFONO { get; set; }
        public string NUMERO { get; set; }
        public string DESCRIPCION { get; set; }
        public int CODIGOPROVEEDOR { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; } //Relacion de 1-1
    }
}
