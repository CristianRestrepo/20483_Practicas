﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cDTO;
using System.Collections;

namespace CContratos.Productos
{
    public interface IProductos
    {
        bool RegistrarProducto(cProducto pProducto);

        bool ActualizarProducto(cProducto pProducto);

        bool EliminarProducto(cProducto pProducto);

        cProducto ConsultarProducto(int pIdProducto);

        ArrayList ConsultarProductos(int pOpc, int pId);

        ArrayList ConsultarProductos(string pValor);

        


    }
}
