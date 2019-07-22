using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class EMAILPROVEEDOR
    {
        public int CODIGOEMAIL { get; set; }
        public string EMAIL { get; set; }
        public int CODIGOPROVEEDOR { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }        //Relacion de 1-1
    }
}
