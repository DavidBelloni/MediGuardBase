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
    public class PatientLogic
    {
        private readonly IPatientRepository patientRepository;

        public PatientLogic()
        {
            // Devuelve una instancia de la clase Patient
            patientRepository = FactoryDao.PatientRepository;
        }

        public void RegisterPatient(Patient patient)
        {
            // Aquí podria agregar validaciones o reglas de negocio antes de registrar el paciente
            patientRepository.add(patient);
        }
    }
}
