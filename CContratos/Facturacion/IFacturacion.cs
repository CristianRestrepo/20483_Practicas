using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cDTO;
namespace cContratos.Facturacion
{
    public interface IFacturacion
    {
        bool GenerarFactura(cFactura pFactura);
    }
}
