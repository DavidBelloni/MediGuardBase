using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface INumeroTicketRepository
    {
        int ObtenerProximoNumero(DateTime date, string prefijo);
        void ActualizarNumeroTicket(DateTime date, int proximoNumero, string prefijo);
    }
}

