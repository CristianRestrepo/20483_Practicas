using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cContratos.Productos;
using cRepositorio.Productos;
using cNegocio.Productos;
using cDTO;

namespace cFacade
{
    public class fTipo
    {
        private ITipos repositorioTipo;
        private cTiposBO tipoLN;

        public fTipo()
        {
            repositorioTipo = new cRepositorioTipos();
            tipoLN = new cTiposBO(repositorioTipo);
        }

        public IEnumerable<cTipo> ConsultarTipos() {
            return tipoLN.ConsultarTipos();
        }




    }
}
