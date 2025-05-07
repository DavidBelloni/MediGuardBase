using DAL.Contracts;
using DAL.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.SqlServer
{
    public class NumeroTicketRepository : INumeroTicketRepository
    {
        #region singleton

        private readonly static NumeroTicketRepository _instance = new NumeroTicketRepository();

        public static NumeroTicketRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private NumeroTicketRepository()
        {

        }
        #endregion

        public int ObtenerProximoNumero(DateTime fechaHora, string prefijo)
        {
            int proximoNumero = 1;
            string commandTextSelect = "SELECT NextNumber FROM Ticket WHERE Date = @Date AND Prefix = @Prefix";
            SqlParameter[] selectParameters = new SqlParameter[]
            {
                new SqlParameter("@Date", fechaHora),
                new SqlParameter("@Prefix", prefijo)
            };

            using (SqlDataReader reader = SqlHelper.ExecuteReader(commandTextSelect, CommandType.Text, selectParameters))
            {
                if (reader.Read())
                {
                    proximoNumero = reader.GetInt32(reader.GetOrdinal("ProximoNumero"));
                }
                else
                {
                    string commandTextInsert = "INSERT INTO Ticket (fechaHora, proximoNumero, prefijo) VALUES (@FechaHora, @ProximoNumero, @Prefijo)";
                    SqlParameter[] insertParameters = new SqlParameter[]
                    {
                        new SqlParameter("@FechaHora", fechaHora),
                        new SqlParameter("@ProximoNumero", proximoNumero),
                        new SqlParameter("@Prefijo", prefijo)
                    };
                    SqlHelper.ExecuteNonQuery(commandTextInsert, CommandType.Text, insertParameters);
                }
            }

            return proximoNumero;
        }

        public void ActualizarNumeroTicket(DateTime fechaHora, int proximoNumero, string prefijo)
        {
            string commandTextUpdate = "UPDATE Ticket SET NextNumber = @NextNumber WHERE Date = @Date AND Prefix = @Prefix";
            SqlParameter[] updateParameters = new SqlParameter[]
            {
                new SqlParameter("@FechaHora", fechaHora),
                new SqlParameter("@ProximoNumero", proximoNumero),
                new SqlParameter("@Prefijo", prefijo)
            };

            SqlHelper.ExecuteNonQuery(commandTextUpdate, CommandType.Text, updateParameters);
        }
    }
}
