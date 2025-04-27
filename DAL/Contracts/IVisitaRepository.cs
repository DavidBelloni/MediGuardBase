using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public  interface IVisitaRepository : IGenericRepository<Visita>
    {
        // Método para agregar una nueva visita
        void Add(Visita visita);

    }
}
