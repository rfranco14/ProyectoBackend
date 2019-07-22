﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Model
{
    public class EmailCliente
    {
        public int CodigoEmail { get; set; }
        public string Email { get; set; }
        public string Nit { get; set; }
        public virtual Cliente Cliente { get; set; }    //Relacion de 1-1
    }
}
