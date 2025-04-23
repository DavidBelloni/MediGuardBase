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
        public void add(Paciente paciente)
        {
            string commandText = "INSERT INTO Paciente (idPaciente, dni, nombre, apellido, celular, email) VALUES (@IdPaciente, @dni, @nombre, @apellido, @celular, @email)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@idPaciente", paciente.idPaciente),
                new SqlParameter("@dni", paciente.numeroDocumento),
                new SqlParameter("@nombre", paciente.nombre),
                new SqlParameter("@apellido", paciente.apellido),
                new SqlParameter("@celular", paciente.celular),
                new SqlParameter("@email", paciente.email),
            };

            SqlHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters);
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

        public List<Paciente> GetByDni(int dni)
        {
            List<Paciente> pacientes = new List<Paciente>();
            string commandText = "SELECT * FROM Paciente WHERE dni = @dni";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dni", dni)
            };

            using (SqlDataReader reader = SqlHelper.ExecuteReader(commandText, CommandType.Text, parameters))
            {
                while (reader.Read())
                {
                    Paciente paciente = new Paciente
                    {
                        idPaciente = reader.GetGuid(reader.GetOrdinal("idPaciente")),
                        tipoDocumento = Enum.TryParse<TipoDocumento>(reader.GetString(reader.GetOrdinal("tipoDocumento")), out var parsedTipoDocumento) ? parsedTipoDocumento : TipoDocumento.DNI,
                        numeroDocumento = reader.GetInt32(reader.GetOrdinal("DNI")),
                        nombre = reader.GetString(reader.GetOrdinal("nombre")),
                        apellido = reader.GetString(reader.GetOrdinal("apellido")),
                        email = reader.GetString(reader.GetOrdinal("email")),
                        celular = reader.GetString(reader.GetOrdinal("celular")),
                        sexo = Enum.TryParse<Sexo>(reader.GetString(reader.GetOrdinal("sexo")), out var parsedSexo) ? parsedSexo : Sexo.Otro,
                        fechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                        coberturaMedica = reader.GetString(reader.GetOrdinal("CoberturaMedica")),
                        tipoCobertura = Enum.TryParse<TipoCobertura>(reader.GetString(reader.GetOrdinal("TipoCobertura")), out var parsedTipoCobertura) ? parsedTipoCobertura : TipoCobertura.Particular,
                    };

                    pacientes.Add(paciente);
                }
            }
            return pacientes;
        }

        public List<Paciente> GetWaitingList()
        {
            return new List<Paciente>();
        }

    }


}
