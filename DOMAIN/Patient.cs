using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Patient
    {
        private Guid idPatient { get; set; }

        private int dni { get; set; }

        private string name { get; set; }

        private string lastName { get; set; }

        private string phone { get; set; }

        private string email { get; set; }

        private string riskGroup { get; set; }

        private string ticketNumber { get; set; }

    }
}
