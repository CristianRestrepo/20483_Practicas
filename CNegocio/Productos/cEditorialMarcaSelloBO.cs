using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cRepositorio.Productos;
using cContratos.Productos;
using cDTO;

namespace cNegocio.Productos
{
    public class cEditorialMarcaSelloBO
    {
        private IEditorialSelloMarca repositorioEditorialSelloMarca;

        public cEditorialMarcaSelloBO(IEditorialSelloMarca pRepositorioEditorialSelloMarca)
        {
            repositorioEditorialSelloMarca = pRepositorioEditorialSelloMarca;
        }

        public IEnumerable<cEdiMarcaSello> ConsultarEditorialMarcaSellos() {
            return repositorioEditorialSelloMarca.ConsultarEdiMarcaSello();
        }
    }
}
