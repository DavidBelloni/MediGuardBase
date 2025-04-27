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
using static DOMAIN.Enums;

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

        public bool ValidarDatosPaciente(Paciente paciente, string grupoRiesgo)
        {
            // Validar que todos los campos obligatorios estén completos
            if (string.IsNullOrWhiteSpace(paciente.nombre) ||
                string.IsNullOrWhiteSpace(paciente.apellido) ||
                string.IsNullOrWhiteSpace(paciente.celular) ||
                string.IsNullOrWhiteSpace(paciente.email) ||
                string.IsNullOrWhiteSpace(paciente.coberturaMedica) ||
                string.IsNullOrWhiteSpace(grupoRiesgo) ||
                paciente.sexo == default(Sexo) || // Comprobación si sexo no está definido
                paciente.tipoCobertura == default(TipoCobertura) ||  // Comprobación si cobertura no está definida
                paciente.tipoDocumento == default(TipoDocumento))
            {
                return false;
            }

            return true;
        }

        public Paciente GetPacienteByDni(int numeroDocumento)
        {
            // Validar que el número de documento sea válido
            if (numeroDocumento <= 0)
            {
                throw new ArgumentException("Debe ingresar un numero de documento valido.");
            }

            // Buscar el paciente por DNI
            return pacienteRepository.GetByDni(numeroDocumento);
        }
    }
}
