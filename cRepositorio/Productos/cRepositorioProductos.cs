using CContratos.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cDTO;
using cRepositorio.LINQ;
using System.Data.Linq.SqlClient;
using System.Collections;

namespace cRepositorio.Productos
{
    class cRepositorioProductos : IProductos
    {
        private ModeloDataContext contexto = new ModeloDataContext();

        public bool ActualizarProducto(cProducto pProducto)
        {
            bool resultado = true;
            var producto = from p in contexto.PRODUCTO
                           where p.IDPRODUCTO.Equals(pProducto.Id)
                           select p;

            foreach (PRODUCTO p in producto)
            {
                p.NOMBRE = pProducto.Nombre;
                p.AUTOR = pProducto.Autor;
                p.IDTIPO = pProducto.IdTipo;
                p.IDEDSEMA = pProducto.IdEditorialSelloMarca;
                p.FECHAPUBLICACION = pProducto.FechaPublicacion;
                p.PRECIO = pProducto.Precio;
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

        public cProducto ConsultarProducto(int pIdProducto)
        {
            var producto = from p in contexto.PRODUCTO
                           where p.IDPRODUCTO.Equals(pIdProducto)
                           select p;

            return (cProducto)producto;
        }

        public ArrayList ConsultarProductos(string pValor)
        {
            ArrayList productos = new ArrayList();
            var productosQuery = from p in contexto.PRODUCTO
                            where 
                            SqlMethods.Like(p.AUTOR, "%" + pValor + "%") ||
                            SqlMethods.Like(p.EDITORIAL_MARCA_SELLO.NOMBRE, "%" + pValor + "%") ||
                            SqlMethods.Like(p.TIPO.NOMBRE, "%" + pValor + "%") ||
                            SqlMethods.Like(p.NOMBRE, "%" + pValor + "%")
                            select p;

            foreach (PRODUCTO p in productosQuery) {
                cProducto producto = new cProducto()
                {
                    Id = p.IDPRODUCTO,
                    Nombre = p.NOMBRE,
                    Autor = p.AUTOR,
                    IdTipo = p.IDTIPO,
                    FechaPublicacion = p.FECHAPUBLICACION,
                    IdEditorialSelloMarca = p.IDEDSEMA
                };
                productos.Add(producto);
            }
            return productos;

        }

        public ArrayList ConsultarProductos(int pOpc, int pId)
        {
            throw new NotImplementedException();
        }

        public bool EliminarProducto(cProducto pProducto)
        {
            bool resultado = true;
            PRODUCTO prod = new PRODUCTO();
            AsignarDTO(ref prod, pProducto);
            contexto.PRODUCTO.DeleteOnSubmit(prod);

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

        public bool RegistrarProducto(cProducto pProducto)
        {
            bool resultado = true;
            PRODUCTO prod = new PRODUCTO();
            AsignarDTO(ref prod, pProducto);
            contexto.PRODUCTO.InsertOnSubmit(prod);

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

        private void AsignarDTO(ref PRODUCTO pProductoLINQ, cProducto pProducto)
        {
            pProductoLINQ.IDPRODUCTO = pProducto.Id;
            pProductoLINQ.NOMBRE = pProducto.Nombre;
            pProductoLINQ.AUTOR = pProducto.Autor;
            pProductoLINQ.IDTIPO = pProducto.IdTipo;
            pProductoLINQ.IDEDSEMA = pProducto.IdEditorialSelloMarca;
            pProductoLINQ.FECHAPUBLICACION = pProducto.FechaPublicacion;
            pProductoLINQ.PRECIO = pProducto.Precio;
        }
    }
}
