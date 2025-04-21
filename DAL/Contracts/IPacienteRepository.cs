using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IPacienteRepository : IGenericRepository<Paciente>

    {
        // Add any additional methods specific to the Patient repository here
        // For example, if you want to add a method to get patients by their status or other criteria
        // List<Patient> GetByStatus(string status);
        List<Paciente> GetByDni(int dni);


    }
}
