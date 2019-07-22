﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class Proveedor
    {
        public int CodigoProveedor { get; set; }
        public string Nit { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Paginaweb { get; set; }
        public string ContactoPrincipal { get; set; }
        public virtual ICollection<Compra>Compras { get; set; }                         //Relacion de 1-n
        public virtual ICollection<EmailProveedor> EmailProveedores { get; set; }        //Relacion de 1-n
        public virtual ICollection<TelefonoProveedor>TelefonoProveedores { get; set; }   //Relacion de 1-n
    }
}
