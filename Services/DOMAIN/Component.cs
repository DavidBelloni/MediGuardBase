using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DOMAIN
{
    public abstract class Component
    {
        public Guid IdComponent { get; }
        public string Nombre { get; protected set; }
        public string Descripcion { get; protected set; }
        public DateTime FechaCreacion { get; protected set; }
        public Component(string nombre, string descripcion)
        {
            IdComponent = Guid.NewGuid();
            Nombre = nombre;
            Descripcion = descripcion;
            FechaCreacion = DateTime.Now;
        }
        // Método para obtener todos los permisos individuales (Patentes)
        public abstract List<Patente> ObtenerPatentes();
    }
}
