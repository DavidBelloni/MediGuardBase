using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class PantallaLlamados
    {
        public Guid idPantallaLlamados { get; set; }
        public string nombre { get; set; }
        public List<Visita> llamados { get; set; }



    }
}
