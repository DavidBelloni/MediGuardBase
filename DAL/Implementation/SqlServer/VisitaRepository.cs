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
using static DOMAIN.Enums;

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
                (idPaciente, idTriage, idEspecialidad, fechaHoraIngreso, fechahoraAusente, estado, grupoRiesgo) 
                VALUES 
                (@idPaciente, @idTriage, @idEspecialidad, @fechaHoraIngreso, @fechahoraAusente, @estado, @grupoRiesgo);";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@idPaciente", visita.idPaciente),
                new SqlParameter("@idTriage", visita.idTriage), 
                new SqlParameter("@idEspecialidad", visita.idEspecialidad),
                new SqlParameter("@fechaHoraIngreso", visita.fechaHoraIngreso),
                new SqlParameter("@fechahoraAusente", (object)visita.fechaHoraAusente ?? DBNull.Value), // Puede ser null
                new SqlParameter("@estado", Convert.ToInt32(visita.estado)), // Enum EstadoVisita
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

        public IEnumerable<Visita> GetAll(EstadoVisita estado)
        {
            // Consulta SQL para obtener todas las visitas con el estado especificado
            string commandText = "SELECT * FROM Visita WHERE estadoVisita = @estadoVisita";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@estadoVisita", (int)estado) // Convertir el enum a entero
            };

            try
            {
                using (var reader = SqlHelper.ExecuteReader(commandText, CommandType.Text, parameters))
                {
                    List<Visita> visitas = new List<Visita>();
                    while (reader.Read())
                    {
                        Visita visita = new Visita
                        {
                            idVisita = reader.GetGuid(reader.GetOrdinal("idVisita")),
                            idPaciente = reader.GetGuid(reader.GetOrdinal("idPaciente")),
                            idTriage = reader.GetGuid(reader.GetOrdinal("idTriage")),
                            idEspecialidad = reader.GetGuid(reader.GetOrdinal("idEspecialidad")),
                            fechaHoraIngreso = reader.GetDateTime(reader.GetOrdinal("fechaHoraIngreso")),
                            fechaHoraAusente = reader.IsDBNull(reader.GetOrdinal("fechahoraAusente")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("fechaHoraAusente")),
                            estado = (EstadoVisita)reader.GetInt32(reader.GetOrdinal("estadoVisita")),
                            grupoRiesgo = (GrupoRiesgo)reader.GetInt32(reader.GetOrdinal("grupoRiesgo"))
                        };
                        visitas.Add(visita);
                    }
                    return visitas;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción y registrar el error
                Console.WriteLine($"Error al obtener las visitas: {ex.Message}");
                throw; // Relanzar la excepción para que sea manejada en niveles superiores
            }
        }

        public Visita GetById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
