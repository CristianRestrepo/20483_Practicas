using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cDTO;

namespace cContratos.Inventario
{
    public interface IInventario
    {
        bool RegistrarInventarioProducto(cInventario pInventario);

        bool ActualizarInventarioProducto(cInventario pInventario);

        cInventario ConsultarInventarioProducto(int pIdProducto);
    }
}
