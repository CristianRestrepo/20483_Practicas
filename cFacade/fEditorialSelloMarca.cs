using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cContratos.Productos;
using cRepositorio.Productos;
using cNegocio.Productos;
namespace cFacade
{
    public class fEditorialSelloMarca
    {
        private IEditorialSelloMarca repositorioEditorialSelloMarca;
        private cEditorialMarcaSelloBO editorialSelloMarcaLN;

        public fEditorialSelloMarca()
        {
            repositorioEditorialSelloMarca = new cRepositorioEditorialMarcaSello();
            editorialSelloMarcaLN = new cEditorialMarcaSelloBO(repositorioEditorialSelloMarca);
        }

        public IEnumerable<cDTO.cEdiMarcaSello> ConsultarEditorialMarcaSellos() {
            return editorialSelloMarcaLN.ConsultarEditorialMarcaSellos();
        }
    }
}
