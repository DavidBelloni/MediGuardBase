using DAL.Contracts;
using DAL.Helpers;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL.Implementation.SqlServer
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

        public void AddTriage(Triage triage)
        {
            //Registrar Triage en la base de datos
            string commandText = @"
                INSERT INTO Triage (motivoVisita, nivelUrgencia, observaciones, especialidad, temperatura, frecuenciaCardiaca, presionArterial, saturacionOxigeno)
                VALUES (@motivoVisita, @nivelUrgencia, @observaciones, @especialidad, @temperatura, @frecuenciaCardiaca, @presionArterial, @saturacionOxigeno)";
            
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@motivoVisita", triage.motivoVisita),
                new SqlParameter("@nivelUrgencia", Convert.ToInt32(triage.nivelUrgencia)),
                new SqlParameter("@observaciones", triage.observaciones),
                new SqlParameter("@especialidad", Convert.ToInt32(triage.especialidad)),
                new SqlParameter("@temperatura", triage.temperatura),
                new SqlParameter("@frecuenciaCardiaca", triage.frecuenciaCardiaca),
                new SqlParameter("@presionArterial", triage.presionArterial),
                new SqlParameter("@saturacionOxigeno", triage.saturacionOxigeno),
            };

            SqlHelper.ExecuteNonQuery(commandText, System.Data.CommandType.Text, parameters);
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

        public Triage Add(Triage obj)
        {
            throw new NotImplementedException();
        }
    }
}