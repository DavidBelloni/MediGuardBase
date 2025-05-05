using DAL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;

namespace DAL.Implementation.Memory
{
    public class TriageRepository : ITriageRepository
    {
        #region singleton
        private readonly static TriageRepository _instance = new TriageRepository();
        public static TriageRepository Current
        {
            get
            {
                return _instance;
            }
        }
        private TriageRepository()
        {

        }
        #endregion

        public void AddTriage(Triage obj)
        {
            throw new NotImplementedException();
        }

        public Triage Add(Triage obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Triage obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Triage> GetAll(Enums.EstadoVisita obj)
        {
            throw new NotImplementedException();
        }

        public Triage GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}