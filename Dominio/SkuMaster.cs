using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class SkuMaster: Sku
    {
       
        public int CantidadxPallet { get; set; }
        public int CantidadxBase { get; set; }
        public int CantidadDeBase { get; set; }
        public int CantidadxCaja { get; set; }
        public int AltoCaja { get; set; }
        public int AltoItem { get; set; }
        public int AnchoCaja { get; set; }
        public int AnchoItem { get; set; }
        public int ProfundidadCaja { get; set; }
        public int ProfundidadItem { get; set; }

    }
}
