using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Almacenar: Locacion
    {

        public int IdCliente { get; set; }
        public int SkuCliente { get; set; }
        public int CantSKU { set; get; }
        public int MaximaCapacidad { set; get; }
        public SkuMaster SkuMaster { set; get; }
        

    }
}
