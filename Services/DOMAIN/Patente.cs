using Services.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    // Clase que representa una patente(permiso) individual, que hereda de Component
    public class Patente : Component
    {
        public Patente(string nombre, string descripcion) : base(nombre, descripcion) { }

        public override List<Patente> ObtenerPatentes()
        {
            return new List<Patente> { this };
        }
    }
}
