using DAL.Contracts;
using DOMAIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.Memory
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

        public void add(Paciente entity)
        {
            throw new NotImplementedException();
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

        public void RegisterPaciente(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> GetByDni(int dni)
        {
            throw new NotImplementedException();
        }

        Paciente IPacienteRepository.GetByDni(int dni)
        {
            throw new NotImplementedException();
        }
    }
}
