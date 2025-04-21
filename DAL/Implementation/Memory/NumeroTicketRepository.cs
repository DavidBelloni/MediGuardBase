using DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.Memory
{
    class NumeroTicketRepository : INumeroTicketRepository
    {
        #region singleton

        private readonly static NumeroTicketRepository _instance = new NumeroTicketRepository();

        public static NumeroTicketRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private NumeroTicketRepository()
        {
        }
        #endregion

        int INumeroTicketRepository.ObtenerProximoNumero(DateTime date, string prefijo)
        {
            throw new NotImplementedException();
        }

        void INumeroTicketRepository.ActualizarNumeroTicket(DateTime date, int proximoNumero, string prefijo)
        {
            throw new NotImplementedException();
        }

    }
}
