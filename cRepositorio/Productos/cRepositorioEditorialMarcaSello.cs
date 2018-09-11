using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cContratos.Productos;
using cDTO;
using cRepositorio.LINQ;

namespace cRepositorio.Productos
{
    public class cRepositorioEditorialMarcaSello : IEditorialSelloMarca
    {
        private ModeloDataContext contexto = new ModeloDataContext();

        public IEnumerable<cEdiMarcaSello> ConsultarEdiMarcaSello()
        {
            List<cEdiMarcaSello> listaEdiMarcaSello = new List<cEdiMarcaSello>();
            IQueryable resultado = from ed in contexto.EDITORIAL_MARCA_SELLO
                                   select ed;

            foreach (EDITORIAL_MARCA_SELLO edi in resultado) {
                listaEdiMarcaSello.Add(AsignarDTO(edi));
            }

            return listaEdiMarcaSello;
        }

        private cEdiMarcaSello AsignarDTO(EDITORIAL_MARCA_SELLO pEditorial) {
            return new cEdiMarcaSello()
            {
                Id = pEditorial.IDEDSEMA,
                Nombre = pEditorial.NOMBRE
            };
        }
    }
}
