using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cContratos;
using cContratos.Productos;
using cContratos.Inventario;
using cDTO;

namespace cNegocio.Productos
{
    public class cProductosBO
    {
        private IProductos RepositorioProductos;
        private IInventario RepositorioInventario;

        public cProductosBO(IProductos pRepoProductos, IInventario pRepoInventario)
        {
            RepositorioProductos = pRepoProductos;
            RepositorioInventario = pRepoInventario;
        }

        public bool RegistrarProducto(cProducto producto, cInventario inventario) {
           return RepositorioProductos.RegistrarProducto(producto, inventario);
        }



    }
}
