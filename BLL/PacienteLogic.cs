using DAL.Contracts;
using DAL.Factory;
using DAL.Implementation.Memory;
using DAL.Implementation.SqlServer;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PacienteLogic
    {
        private readonly IPacienteRepository pacienteRepository;

        public PacienteLogic()
        {
            // Devuelve una instancia de la clase Patient
            pacienteRepository = FactoryDao.PacienteRepository;
        }

        public void RegisterPaciente(Paciente paciente)
        {
            // Aquí podria agregar validaciones o reglas de negocio antes de registrar el paciente
            pacienteRepository.add(paciente);
        }

        public List<Paciente> GetPacienteByDni(int dni)
        {
            return pacienteRepository.GetByDni(dni);
        }
    }
}
