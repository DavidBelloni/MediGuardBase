using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    // Clase auxiliar para manejar números de atención
    public class NumeroAtencion
    {
        public string Prefijo { get; set; }
        public int Secuencial { get; set; }

        // Propiedad Calculada
        public string Completo => $"{Prefijo} {Secuencial:D3}"; // Sigue siendo útil

        // Puedes omitir los constructores por ahora, o solo tener uno simple
        public NumeroAtencion(string prefijo, int secuencial)
        {
            Prefijo = prefijo;
            Secuencial = secuencial;
        }

        // Y quizás no necesites FromString si siempre creas el objeto con sus partes,
        // o si lo guardas como string y solo lo pasas a string.
    }
}
