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

namespace DAL.Implementation.SqlServer
{
    public class VisitaRepository
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
        public void Add(Visita visita)
        {
            string commandText = "INSERT INTO Visita (pacienteId, fechaHora, grupoRiesgo, motivo, observaciones) " +
                                 "VALUES (@pacienteId, @fechaHora, @grupoRiesgo, @motivo, @observaciones);";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@fechaHora", visita.FechaHora),
        new SqlParameter("@grupoRiesgo", visita.grupoRiesgo),
        new SqlParameter("@motivo", visita.motivoVisita),
        new SqlParameter("@observaciones", visita.observaciones)
            };

            SqlHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters);
        }
    }
}
