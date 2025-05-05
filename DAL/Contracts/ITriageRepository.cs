using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface ITriageRepository : IGenericRepository<Triage>
    {
        void AddTriage(Triage obj);
    }
}
