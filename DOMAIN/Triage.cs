using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Triage
    {
        public Guid idTriage { get; set; }
        public int nivelUrgencia { get; set; }
        public string observacion { get; set; }
        public DateTime fechaHoraTriage { get; set; }
        public Triage()
        {

        }
    }
}
