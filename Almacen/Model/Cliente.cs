using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class Cliente
    {
        public string Nit { get; set; }
        public string Dpi { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public virtual ICollection<Factura>Facturas { get; set; }                   //Relacion de 1-n
        public virtual ICollection<EmailCliente>EmailClientes { get; set; }         //Relacion de 1-n
        public virtual ICollection<TelefonoCliente>TelefonoClientes { get; set; }   //Relacion de 1-n
    }
}
