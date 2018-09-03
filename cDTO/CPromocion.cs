using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDTO
{
    public class cPromocion
    {
        private int id;

        public int IdTipo { get; set; }

        public int IdEditorialSelloMarca { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int Descuento { get; set; }

        public int Estado { get; set; }
    }
}
