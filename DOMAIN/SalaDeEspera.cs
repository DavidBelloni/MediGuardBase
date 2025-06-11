using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class SalaDeEspera
    {
        public Guid idSalaDeEspera { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public int capacidad { get; set; }
        public bool estado { get; set; }

    }
}
