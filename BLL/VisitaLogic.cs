using DAL.Contracts;
using DAL.Factory;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DOMAIN.Enums;

namespace BLL
{
    public  class VisitaLogic
    {

        private readonly IVisitaRepository visitaRepository;

        public VisitaLogic()
        {
            // Devuelve una instancia de la clase Visita
            visitaRepository = FactoryDao.VisitaRepository;
        }

        public List<Visita> ObtenerVisitasPorEstado(EstadoVisita estado)
        {
            // Delegar el filtro al repositorio
            return visitaRepository.GetAll(estado).ToList();
        }

        public void RegistrarVisita(Paciente paciente, string grupoRiesgo)
        {
            var pacienteLogic = new PacienteLogic();

            // Validar datos del paciente y formulario
            if (!pacienteLogic.ValidarDatosPaciente(paciente, grupoRiesgo))
            {
                throw new ArgumentException("Por favor, complete todos los campos obligatorios.");
            }

            Paciente pacienteFinal;

            // Validar si el paciente ya existe 
            var pacienteExistente = pacienteLogic.GetPacienteByDni(paciente.numeroDocumento, paciente.tipoDocumento);

            if (pacienteExistente == null)
            {
                // Registrar paciente si no existe
                pacienteFinal = pacienteLogic.RegistrarPaciente(paciente);
            }
            else
            {
                // Utilizar el paciente existente
                pacienteFinal = pacienteExistente;
            }

            // Registrar la visita
            var visita = new Visita
            {
                idPaciente = pacienteFinal.idPaciente,
                grupoRiesgo = (GrupoRiesgo)Enum.Parse(typeof(GrupoRiesgo), grupoRiesgo),
            };

            // Agregar la visita al repositorio
            visitaRepository.Add(visita);

        }
    }
}
