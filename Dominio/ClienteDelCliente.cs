using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public  class ClienteDelCliente : Cliente
    {
        public int IdClienteDelCliente { get; set; }
        public string NombreCDC { get; set; }
        public string DireccionDeEntrega { get; set; }

    }
}
