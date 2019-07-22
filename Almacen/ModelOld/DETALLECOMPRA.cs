using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class DETALLECOMPRA
    {
        public int IDDETALLE { get; set; }
        public int IDCOMPRA { get; set; }
        public int CODIGOPRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public decimal PRECIO { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }  //Relaicon de 1-1
        public virtual COMPRA COMPRA { get; set; }      //Relacion de 1-1
    }
}
