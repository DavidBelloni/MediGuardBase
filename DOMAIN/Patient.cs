using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Patient
    {
        public Guid idPatient { get; set; }

        public int dni { get; set; }

        public string name { get; set; }

        public string lastName { get; set; }

        public string phone { get; set; }

        public string email { get; set; }

        public string riskGroup { get; set; }

        public string ticketNumber { get; set; }

    }
}
