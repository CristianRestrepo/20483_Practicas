using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cContratos;
using cContratos.Productos;
using cDTO;
using cRepositorio.LINQ;

namespace cRepositorio.Productos
{
    public class cRepositorioTipos : ITipos
    {

        ModeloDataContext contexto = new ModeloDataContext();

        public IEnumerable<cTipo> ConsultarTipos()
        {
            List<cTipo> tipos = new List<cTipo>();
            IQueryable resultado = from p in contexto.TIPO
                                   select p;

            foreach (TIPO t in resultado)
            {
                tipos.Add(AsignarDTO(t));
            }
            return tipos;
        }

        private cTipo AsignarDTO(TIPO pTipo)
        {
            return new cTipo()
            {
                Id = pTipo.IDTIPO,
                Nombre = pTipo.NOMBRE
            };
        }

    }
}

