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
                "INSERT INTO Paciente (tipoDocumento, numeroDocumento, nombre, apellido, celular, email, sexo, fechaNacimiento, coberturaMedica, tipoCobertura, fechaCreacion) " +
                "OUTPUT INSERTED.idPaciente " + // Devuelve el idPaciente generado automáticamente
                "VALUES (@tipoDocumento, @numeroDocumento, @nombre, @apellido, @celular, @email, @sexo, @fechaNacimiento, @coberturaMedica, @tipoCobertura, @fechaCreacion)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tipoDocumento", Convert.ToInt32(paciente.tipoDocumento)),
                new SqlParameter("@numeroDocumento", paciente.numeroDocumento),
                new SqlParameter("@nombre", paciente.nombre),
                new SqlParameter("@apellido", paciente.apellido),
                new SqlParameter("@celular", paciente.celular),
                new SqlParameter("@email", paciente.email),
                new SqlParameter("@sexo", Convert.ToInt32(paciente.sexo)),
                new SqlParameter("@fechaNacimiento", paciente.fechaNacimiento),
                new SqlParameter("@coberturaMedica", paciente.coberturaMedica),
                new SqlParameter("@tipoCobertura", Convert.ToInt32(paciente.tipoCobertura)),
                new SqlParameter("@fechaCreacion", DateTime.Now)    

            };

            // Ejecutar el comando y capturar el idPaciente generado
            object result = SqlHelper.ExecuteScalar(commandText, CommandType.Text, parameters);

            // Asignar el idPaciente generado al objeto Paciente
            paciente.idPaciente = (Guid)result;

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
            
            string commandText = "SELECT TOP 1 * FROM Paciente WHERE numeroDocumento = @numeroDocumento AND tipoDocumento = @tipoDocumento";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@numeroDocumento", numeroDocumento),
                new SqlParameter("@tipoDocumento", Convert.ToInt32(tipoDocumento))
            };

            using (var reader = SqlHelper.ExecuteReader(commandText, CommandType.Text, parameters))
            {
                if (reader.Read())
                {
                    return new Paciente
                    {
                        idPaciente = reader.GetGuid(reader.GetOrdinal("idPaciente")),
                        numeroDocumento = reader.GetInt32(reader.GetOrdinal("numeroDocumento")),
                        tipoDocumento = (TipoDocumento)reader.GetInt32(reader.GetOrdinal("tipoDocumento")),
                        nombre = reader.GetString(reader.GetOrdinal("nombre")),
                        apellido = reader.GetString(reader.GetOrdinal("apellido")),
                        celular = reader.GetString(reader.GetOrdinal("celular")),
                        email = reader.GetString(reader.GetOrdinal("email")),
                        sexo = (Sexo)reader.GetInt32(reader.GetOrdinal("sexo")),
                        fechaNacimiento = reader.GetDateTime(reader.GetOrdinal("fechaNacimiento")),
                        coberturaMedica = reader.GetString(reader.GetOrdinal("coberturaMedica")),
                        tipoCobertura = (TipoCobertura)reader.GetInt32(reader.GetOrdinal("tipoCobertura")),

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
