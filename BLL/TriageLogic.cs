using DAL.Contracts;
using DAL.Factory;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TriageLogic
    {
        private readonly ITriageRepository triageRepository;

        public TriageLogic()
        {
            // Devuelve una instancia de la clase Triage
            triageRepository = FactoryDao.TriageRepository;
        }

        public void RegistrarTriage(Triage triage)
        {
            //Validar los datos del triage
            if (!ValidarDatosTriage(triage))
            {
                throw new ArgumentException("Complete todos los campos obligatorios");
            }

            //Registrar el triage
            triageRepository.AddTriage(triage);
        }

        public bool ValidarDatosTriage(Triage triage)
        {
            // Validar que todos los campos obligatorios estén completos
            if (string.IsNullOrWhiteSpace(triage.motivoVisita) ||
                string.IsNullOrWhiteSpace(triage.observaciones) ||
                string.IsNullOrWhiteSpace(triage.presionArterial) || // Comprobación si presión arterial no es válida
                triage.nivelUrgencia < 0 || // Comprobación si nivel de urgencia no está definido
                triage.especialidad < 0 || // Comprobación si especialidad no está definida
                triage.temperatura <= 0 || // Comprobación si temperatura no es válida
                triage.frecuenciaCardiaca <= 0 || // Comprobación si frecuencia cardíaca no es válida
                triage.saturacionOxigeno <= 0) // Comprobación si saturación de oxígeno no es válida
            {
                return false;
            }
            return true;
        }

    }
}
