using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cDTO;
namespace cContratos.Productos
{
    public interface IEditorialSelloMarca
    {
        IEnumerable<cEdiMarcaSello> ConsultarEdiMarcaSello();
    }
}
