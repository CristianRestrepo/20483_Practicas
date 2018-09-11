using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cNegocio.Productos;
using cRepositorio.Productos;
using cRepositorio.Inventario;
using cContratos.Productos;
using cContratos.Inventario;
using cDTO;
namespace cFacade
{
    public class fProducto
    {
        cProductosBO productosLN;
        IProductos repositorioProductos;
        IInventario repositorioInventario;

        public fProducto()
        {
            repositorioProductos = new cRepositorioProductos();
            repositorioInventario = new cRepositorioInventario();
            productosLN = new cProductosBO(repositorioProductos, repositorioInventario);
        }

        public bool GuardarProductos(cProducto pProducto, cInventario pInventario)
        {
            if (pProducto != null && pInventario != null)
            {
                return productosLN.RegistrarProducto(pProducto, pInventario);
            }
            else {
                return false;
            }
        }
        
    }
}
