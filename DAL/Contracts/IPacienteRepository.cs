using DOMAIN;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DOMAIN.Enums;

namespace DAL.Contracts
{
    public interface IPacienteRepository : IGenericRepository<Paciente>

    {
        // Método para buscar un paciente por DNI
        Paciente GetByDni(int numeroDocumento, TipoDocumento tipoDocumento);
    }
}
