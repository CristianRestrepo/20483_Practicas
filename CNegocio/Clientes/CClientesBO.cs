using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cContratos.Clientes;

namespace cNegocio.Clientes
{
    class cClientesBO
    {
        private IClientes RepositorioCliente;
        
        public cClientesBO(IClientes pRepoCliente)
        {
            RepositorioCliente = pRepoCliente;
        }
    }
}
