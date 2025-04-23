using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Usuario
    {
        public Guid idUsuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Familia familia { get; set; }
        public List<Patente> patentes { get; set; }
        public DateTime fechaCreacion { get; set; }

        public Usuario()
        {
            fechaCreacion = DateTime.Now;
        }

    }
}
