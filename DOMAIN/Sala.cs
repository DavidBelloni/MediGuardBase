using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Sala
    {
        public Guid IdSala { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Guid IdTipoSala { get; set; }
        public int Capacidad { get; set; }
        public bool EstaActiva { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Sala(string nombre, string descripcion, Guid idTipoSala)
        {
            IdSala = Guid.NewGuid();
            Nombre = nombre;
            Descripcion = descripcion;
            IdTipoSala = idTipoSala;
            Capacidad = 100; // Valores por defecto
            EstaActiva = true;
            FechaCreacion = DateTime.Now;
        }
    }
}
