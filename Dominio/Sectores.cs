using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sectores:Warehouse
    {
        public int IdTipoProducto { get; set; }

        public string NombreTipoProducto { set; get; }

        public int MinimoNivel { set; get; }
        public int MinimoUbicacion { set; get; }
        public int MinimoPasillo { set; get; }
        public int MaximoNivel { set; get; }
        public int MaximoUbicacion { set; get; }
        public int MaximoPasillo { set; get; }

    }
}
