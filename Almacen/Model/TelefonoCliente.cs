﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class TelefonoCliente
    {
        public int CodigoTelefono { get; set; }
        public string Numero { get; set; }
        public string Descripcion { get; set; }
        public string Nit { get; set; }
        public virtual Cliente Cliente { get; set; }        //Relacion de 1-1
    }
}
