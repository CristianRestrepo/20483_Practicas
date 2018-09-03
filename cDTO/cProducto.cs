using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDTO
{
    public class cProducto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Autor { get; set; }

        public int IdTipo { get; set; }

        public decimal Precio { get; set; }

        public DateTime FechaPublicacion { get; set; }

        public int IdEditorialSelloMarca { get; set; }

    }
}
