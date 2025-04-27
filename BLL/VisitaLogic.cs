using DAL.Contracts;
using DAL.Factory;
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

        private readonly IVisitaRepository visitaRepository;

        public VisitaLogic()
        {
            // Devuelve una instancia de la clase Visita
            visitaRepository = FactoryDao.VisitaRepository;
        }
        public void RegistrarVisita(Visita visita)
        {
            // Metodo para registrar una visita 

        }
    }
}
