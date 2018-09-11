using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cContratos.Productos;
using cDTO;

namespace cNegocio.Productos
{
    public class cTiposBO
    {
        private ITipos repositorioTipo;

        //inyeccion de dependencias
        public cTiposBO(ITipos pRepositorioTipo)
        {
            repositorioTipo = pRepositorioTipo;
        }

        public IEnumerable<cTipo> ConsultarTipos() {
            return repositorioTipo.ConsultarTipos();
        }
    }
}
