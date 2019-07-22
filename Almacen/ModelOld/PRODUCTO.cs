using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class PRODUCTO
    {
        public int CODIGOPRODUCTO { get; set; }
        public int  CODIGOCATEGORIA { get; set; }
        public int CODIGOEMPAQUE { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal PRECIOUNITARIO { get; set; }
        public decimal PRECIOPORDOCENA { get; set; }
        public decimal PRECIOPORMAYOR { get; set; }
        public int EXISTENCIA { get; set; }
        public string IMAGEN { get; set; }
        public virtual CATEGORIA CATEGORIA { get; set; }                        //Relacion de 1-1
        public virtual ICollection<INVENTARIO> INVENTARIOS { get; set; }        //Relacion de 1-n
        public virtual TIPOEMPAQUE TIPOEMPAQUE { get; set; }                    //Relacion de 1-1
        public virtual ICollection<DETALLECOMPRA>DETALLECOMPRAS { get; set; }   //Relacion de 1-n
        public virtual ICollection<DETALLEFACTURA>DETALLEFACTURAS { get; set; } //Relacion de 1-n
    }
}
