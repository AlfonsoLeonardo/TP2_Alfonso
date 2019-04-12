using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Locacion:Sectores

    {
        public int IdLocacion { get; set; }
        public Ubicacion ubicacion { get; set; }
        public Pasillo Pasillo { get; set; }
        public Nivel Nivel { get; set; }
        

    }
}
