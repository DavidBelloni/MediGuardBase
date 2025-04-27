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
            // Devuelve una instancia de la clase Paciente
            pacienteRepository = FactoryDao.PacienteRepository;
        }

        public void RegistrarPaciente(Paciente paciente)
        {
            pacienteRepository.add(paciente);
        }

        public bool ValidarDni(string dniTexto, out int dni)
        {
            dni = 0;
            if (string.IsNullOrWhiteSpace(dniTexto) || !int.TryParse(dniTexto, out dni))
            {
                return false;
            }
            return true;
        }

        public bool ValidarDatosFormulario(Paciente paciente, string grupoRiesgo)
        {
            if (string.IsNullOrWhiteSpace(paciente.nombre) ||
                string.IsNullOrWhiteSpace(paciente.apellido) ||
                string.IsNullOrWhiteSpace(grupoRiesgo))
            {
                return false;
            }
            return true;
        }

        public Paciente GetPacienteByDni(int numeroDocumento)
        {
            return pacienteRepository.GetByDni(numeroDocumento);
        }
    }
}
