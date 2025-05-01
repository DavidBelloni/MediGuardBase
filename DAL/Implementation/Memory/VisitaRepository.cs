using DAL.Contracts;
using DOMAIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.Memory
{
    public class VisitaRepository : IVisitaRepository
    {
        private static List<Visita> _list;
        #region singleton  
        private readonly static VisitaRepository _instance = new VisitaRepository();

        public static VisitaRepository Current 
        {
            get
            {
                return _instance;
            }
        }

        private VisitaRepository()
        {
            _list = new List<Visita>();
        }
        #endregion

        public Visita Add(Visita visita)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Visita> GetAll()
        {
            throw new NotImplementedException();
        }

        public Visita GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Visita obj)
        {
            throw new NotImplementedException();
        }
    }
}
