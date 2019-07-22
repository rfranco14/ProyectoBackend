using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class EMAILCLIENTE
    {
        public int CODIGOEMAIL { get; set; }
        public string EMAIL { get; set; }
        public string NIT { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }    //Relacion de 1-1
    }
}
