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
    public class PatientRepository : IPatientRepository

    {
        private static List<Patient> _list;

        #region singleton
        private readonly static PatientRepository _instance = new PatientRepository();

        public static PatientRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private PatientRepository()
        {
            _list = new List<Patient>();
        }
        #endregion

        public void add(Patient entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patient> GetAll()
        {
            throw new NotImplementedException();
        }

        public Patient GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Patient entity)
        {
            throw new NotImplementedException();
        }

        public void PatientRegister(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
