using DAL.Tools;
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
                (IdPaciente, IdTriage, IdEspecialidad, FechaHoraIngreso, fechahoraAusente, estadoVisita, GrupoRiesgo) 
                VALUES 
                (@IdPaciente, @IdTriage, @IdEspecialidad, @FechaHoraIngreso, @fechahoraAusente, @estadoVisita, @GrupoRiesgo);";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdPaciente", visita.IdPaciente),
                new SqlParameter("@IdTriage", visita.IdTriage), 
                new SqlParameter("@IdEspecialidad", visita.IdEspecialidad),
                new SqlParameter("@FechaHoraIngreso", visita.FechaHoraIngreso),
                new SqlParameter("@fechahoraAusente", (object)visita.FechaHoraAusente ?? DBNull.Value), // Puede ser null
                new SqlParameter("@estadoVisita", Convert.ToInt32(visita.Estado)), // Enum EstadoVisita
                new SqlParameter("@GrupoRiesgo", Convert.ToInt32(visita.GrupoRiesgo)) // Enum GrupoRiesgo
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
            string commandText = @"
                SELECT v.*, 
                       p.Nombre AS PacienteNombre, 
                       p.Apellido AS PacienteApellido, 
                       p.NumeroDocumento AS PacienteDocumento, 
                       p.Sexo AS PacienteSexo, 
                       p.FechaNacimiento AS PacienteFechaNacimiento
                FROM Visita v
                INNER JOIN Paciente p ON v.IdPaciente = p.IdPaciente
                WHERE v.estadoVisita = @estadoVisita";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@estadoVisita", (int)estado)
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
                            IdVisita = reader.GetGuid(reader.GetOrdinal("IdVisita")),
                            IdPaciente = reader.GetGuid(reader.GetOrdinal("IdPaciente")),
                            IdTriage = reader.GetGuid(reader.GetOrdinal("IdTriage")),
                            IdEspecialidad = reader.GetGuid(reader.GetOrdinal("IdEspecialidad")),
                            FechaHoraIngreso = reader.GetDateTime(reader.GetOrdinal("FechaHoraIngreso")),
                            FechaHoraAusente = reader.IsDBNull(reader.GetOrdinal("fechahoraAusente")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("FechaHoraAusente")),
                            Estado = (EstadoVisita)reader.GetInt32(reader.GetOrdinal("estadoVisita")),
                            GrupoRiesgo = (GrupoRiesgo)reader.GetInt32(reader.GetOrdinal("GrupoRiesgo")),

                            // Datos del paciente relacionados
                            Paciente = new Paciente
                            {
                                Nombre = reader.GetString(reader.GetOrdinal("PacienteNombre")),
                                Apellido = reader.GetString(reader.GetOrdinal("PacienteApellido")),
                                NumeroDocumento = reader.GetInt32(reader.GetOrdinal("PacienteDocumento")),
                                Sexo = (Sexo)reader.GetInt32(reader.GetOrdinal("PacienteSexo")),
                                FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("PacienteFechaNacimiento"))
                            }
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
