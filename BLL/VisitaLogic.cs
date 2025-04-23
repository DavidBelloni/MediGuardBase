using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class VisitaLogic
    {
        public void RegistrarVisita(Visita visita)
        {
            visitaRepository.Add(visita);
        }
    }
}
