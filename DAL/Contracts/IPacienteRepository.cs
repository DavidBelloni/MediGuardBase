using DOMAIN;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IPacienteRepository : IGenericRepository<Paciente>

    {
        // Método para buscar un paciente por DNI
        Paciente GetByDni(int numeroDocumento);
    }
}
