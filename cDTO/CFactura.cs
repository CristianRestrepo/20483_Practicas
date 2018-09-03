using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDTO
{
    public class cFactura
    {
        public int NumeroFactura { get; set; }

        public int IdentificacionCliente { get; set; }

        public double CostoTotal { get; set; }

        public DateTime FechaFactura { get; set; }
    }
}
