using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class CATEGORIA
    {
        public int CODIGOCATEGORIA { get; set; }
        public string DESCRIPCION { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }    //Relacion de 1-n 
    }
}
