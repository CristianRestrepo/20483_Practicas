using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cContratos;
using CContratos.Productos;
using cContratos.Inventario;

namespace cNegocio.Productos
{
    class cProductosBO
    {
        private IProductos RepositorioProductos;
        private IInventario RepositorioInventario;

        public cProductosBO(IProductos pRepoProductos, IInventario pRepoInventario)
        {
            RepositorioProductos = pRepoProductos;
            RepositorioInventario = pRepoInventario;
        }
    }
}
