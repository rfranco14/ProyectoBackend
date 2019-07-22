using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class TELEFONOCLIENTE
    {
        public int CODIGOTELEFONO { get; set; }
        public string NUMERO { get; set; }
        public string DESCRIPCION { get; set; }
        public string NIT { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }        //Relacion de 1-1
    }
}
