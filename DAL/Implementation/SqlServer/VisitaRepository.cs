using DAL.Helpers;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DAL.Contracts;
using System.Runtime.InteropServices;

namespace DAL.Implementation.SqlServer
{
    public class VisitaRepository : IVisitaRepository
    {
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
            //_list = new List<Visita>();
        }
        #endregion
        public Visita Add(Visita visita)
        {
            string commandText = @"
                INSERT INTO Visita 
                (idPaciente, idTriage, idEspecialidad, fechaHoraIngreso, fechahoraAusente, estadoVisita, grupoRiesgo) 
                VALUES 
                (@idPaciente, @idTriage, @idEspecialidad, @fechaHoraIngreso, @fechahoraAusente, @estadoVisita, @grupoRiesgo);";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@idPaciente", visita.idPaciente),
                new SqlParameter("@idTriage", visita.idTriage), 
                new SqlParameter("@idEspecialidad", visita.idEspecialidad),
                new SqlParameter("@fechaHoraIngreso", visita.fechaHoraIngreso),
                new SqlParameter("@fechahoraAusente", (object)visita.fechaHoraAusente ?? DBNull.Value), // Puede ser null
                new SqlParameter("@estadoVisita", Convert.ToInt32(visita.estadoVisita)), // Enum EstadoVisita
                new SqlParameter("@grupoRiesgo", Convert.ToInt32(visita.grupoRiesgo)) // Enum GrupoRiesgo
            };

            SqlHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters);
            return visita;
        }


        public void Update(Visita obj)
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

    }
}
