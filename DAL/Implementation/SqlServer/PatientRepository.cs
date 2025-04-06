using DAL.Contracts;
using DAL.Helpers;
using DOMAIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Implementation.SqlServer
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
        public void add(Patient patient)
        {
            string commandText = "INSERT INTO Patient (idPatient, dni, name, lastName, phone, email, riskGroup, ticketNumber) VALUES (@IdPatient, @dni, @name, @lastName, @phone, @email, @riskGroup, @ticketNumber)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@idPatient", patient.idPatient),
                new SqlParameter("@dni", patient.dni),
                new SqlParameter("@name", patient.name),
                new SqlParameter("@lastName", patient.lastName),
                new SqlParameter("@phone", patient.phone),
                new SqlParameter("@email", patient.email),
                new SqlParameter("@riskGroup", patient.riskGroup),
                new SqlParameter("@ticketNumber", patient.ticketNumber)
            };

            SqlHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters);
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

        public List<Patient> GetByDni(int dni)
        {
            return new List<Patient>();
        }

        public List<Patient> GetWaitingList()
        {
            return new List<Patient>();
        }
    }


}
