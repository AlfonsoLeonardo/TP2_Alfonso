﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Orden : Cliente
    {
        public int IdOrden { get; set; }
        public List <ClienteDelCliente> ClienteDelCliente { get; set; }
        public List<Sku> Skus { get; set; }
        public List<SkuMaster> SkuMasters { get; set; }
        public int Cantidad { get; set; }


        }
}
