using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cDTO;


namespace cContratos.Clientes
{
    public interface IClientes
    {
        //las interfaces deben determinar los compartimientos
        //publicos de la clase que las implementa

        bool RegistrarCliente(cCliente pCliente);

        bool ActualizarCliente(cCliente pCliente);

        bool EliminarCliente(cCliente pCliente);

        cCliente ConsultarCliente(int pIdentificacion);        
    }
}
