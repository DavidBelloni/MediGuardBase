using DAL.Contracts;
using DAL.Tools;
using DOMAIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static DOMAIN.Enums;

namespace DAL.Implementation.SqlServer
{
    public class PacienteRepository : IPacienteRepository
    {
        private static List<Paciente> _list;

        #region singleton
        private readonly static PacienteRepository _instance = new PacienteRepository();

        public static PacienteRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private PacienteRepository()
        {
            _list = new List<Paciente>();
        }
        #endregion
        public Paciente Add(Paciente paciente)
        {
            string commandText = 
                "INSERT INTO Paciente (TipoDocumento, NumeroDocumento, Nombre, Apellido, Celular, Email, Sexo, FechaNacimiento, CoberturaMedica, TipoCobertura, FechaCreacion) " +
                "OUTPUT INSERTED.IdPaciente " + // Devuelve el idPaciente generado automáticamente
                "VALUES (@TipoDocumento, @NumeroDocumento, @Nombre, @Apellido, @Celular, @Email, @Sexo, @FechaNacimiento, @CoberturaMedica, @TipoCobertura, @FechaCreacion)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TipoDocumento", Convert.ToInt32(paciente.TipoDocumento)),
                new SqlParameter("@NumeroDocumento", paciente.NumeroDocumento),
                new SqlParameter("@Nombre", paciente.Nombre),
                new SqlParameter("@Apellido", paciente.Apellido),
                new SqlParameter("@Celular", paciente.Celular),
                new SqlParameter("@Email", paciente.Email),
                new SqlParameter("@Sexo", Convert.ToInt32(paciente.Sexo)),
                new SqlParameter("@FechaNacimiento", paciente.FechaNacimiento),
                new SqlParameter("@CoberturaMedica", paciente.CoberturaMedica),
                new SqlParameter("@TipoCobertura", Convert.ToInt32(paciente.TipoCobertura)),
                new SqlParameter("@FechaCreacion", DateTime.Now)    

            };

            // Ejecutar el comando y capturar el idPaciente generado
            object result = SqlHelper.ExecuteScalar(commandText, CommandType.Text, parameters);

            // Asignar el idPaciente generado al objeto Paciente
            paciente.IdPaciente = (Guid)result;

            // Devolver el objeto Paciente actualizado
            return paciente;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Paciente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Paciente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Paciente entity)
        {
            throw new NotImplementedException();
        }

        public Paciente GetByDni(int numeroDocumento, TipoDocumento tipoDocumento)
        {
            
            string commandText = "SELECT TOP 1 * FROM Paciente WHERE NumeroDocumento = @NumeroDocumento AND TipoDocumento = @TipoDocumento";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NumeroDocumento", numeroDocumento),
                new SqlParameter("@TipoDocumento", Convert.ToInt32(tipoDocumento))
            };

            using (var reader = SqlHelper.ExecuteReader(commandText, CommandType.Text, parameters))
            {
                if (reader.Read())
                {
                    return new Paciente
                    {
                        IdPaciente = reader.GetGuid(reader.GetOrdinal("IdPaciente")),
                        NumeroDocumento = reader.GetInt32(reader.GetOrdinal("NumeroDocumento")),
                        TipoDocumento = (TipoDocumento)reader.GetInt32(reader.GetOrdinal("TipoDocumento")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                        Celular = reader.GetString(reader.GetOrdinal("Celular")),
                        Email = reader.GetString(reader.GetOrdinal("Email")),
                        Sexo = (Sexo)reader.GetInt32(reader.GetOrdinal("Sexo")),
                        FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                        CoberturaMedica = reader.GetString(reader.GetOrdinal("CoberturaMedica")),
                        TipoCobertura = (TipoCobertura)reader.GetInt32(reader.GetOrdinal("TipoCobertura")),

                    };
                }
            }

            // If no record is found, return null
            return null;
        }

        public List<Paciente> GetWaitingList()
        {
            return new List<Paciente>();
        }

        public IEnumerable<Paciente> GetAll(EstadoVisita obj)
        {
            throw new NotImplementedException();
        }
    }


}
