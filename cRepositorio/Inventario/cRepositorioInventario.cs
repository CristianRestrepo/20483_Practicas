using cContratos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cDTO;
using cRepositorio.LINQ;

namespace cRepositorio.Inventario
{
    class cRepositorioInventario : IInventario
    {
        private ModeloDataContext contexto = new ModeloDataContext();

        public bool ActualizarInventarioProducto(cInventario pInventario)
        {
            bool resultado = true;
            var inventario = from i in contexto.INVENTARIO
                             where i.ID.Equals(pInventario.Id)
                             select i;
            foreach (INVENTARIO i in inventario) {
                i.IDPRODUCTO = pInventario.IdProducto;
                i.CANTIDAD = pInventario.Cantidad;
            }
            
            try
            {
                contexto.SubmitChanges();
            }
            catch (Exception)
            {
                resultado = false;
                throw;
            }
            return resultado;
        }


        public cInventario ConsultarInventarioProducto(int pIdProducto)
        {
            var inventario = from i in contexto.INVENTARIO
                             where i.IDPRODUCTO.Equals(pIdProducto)
                             select i;

            return (cInventario)inventario;
        }

        public bool RegistrarInventarioProducto(cInventario pInventario)
        {
            bool resultado = true;
            INVENTARIO inventario = new INVENTARIO();
            AsignarDTO(ref inventario, pInventario);
            contexto.INVENTARIO.InsertOnSubmit(inventario);

            try
            {
                contexto.SubmitChanges();
            }
            catch (Exception)
            {
                resultado = false;
                throw;
            }
            return resultado;
        }

        private void AsignarDTO(ref INVENTARIO pInventarioLINQ, cInventario pInventario) {
            pInventarioLINQ.IDPRODUCTO = pInventario.IdProducto;
            pInventarioLINQ.CANTIDAD = pInventario.Cantidad;
        }
    }
}
