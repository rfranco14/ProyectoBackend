using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class INVENTARIO
    {
        public int CODIGOINVENTARIO { get; set; }
        public int CODIGOPRODUCTO { get; set; }
        public DateTime FECHA { get; set; }
        public string TIPOREGISTRO { get; set; }
        public double PRECIO { get; set; }
        public int ENTRADAS { get; set; }
        public int SALIDAS { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }  //Relacion de 1-1
    }
}
