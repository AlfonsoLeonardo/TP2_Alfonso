using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : Warehouse
    {
        public int IdCliente { get; set; }
        private string NombreCliente { get; set; }
    }
}
