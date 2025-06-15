using Services.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Patente : Componente
    {
        public Patente(string nombre) : base(nombre) { }

        public override List<Patente> ObtenerPatentes()
        {
            return new List<Patente> { this };
        }
    }
}
