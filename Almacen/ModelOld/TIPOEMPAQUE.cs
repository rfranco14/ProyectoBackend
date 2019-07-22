using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class TIPOEMPAQUE
    {
        public int CODIGOEMPAQUE { get; set; }
        public string DESCRIPCION { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }    //Relaicon de 1-n
    }
}
