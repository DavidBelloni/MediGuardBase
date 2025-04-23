using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Familia
    {
        public Guid idFamilia { get; set; } // Identificador único del rol.
        public string nombre { get; set; } // Nombre del rol, como "Médico", "Recepcionista", "Enfermero".
        public List<Patente> Permisos { get; set; } // Lista de permisos asociados al rol.

        // Constructor para inicializar una Familia
        public Familia(int idFamilia, string nombre)
        {
        }

        // Constructor vacío
        public Familia()
        {
            Permisos = new List<Patente>();
        }
    }
}
