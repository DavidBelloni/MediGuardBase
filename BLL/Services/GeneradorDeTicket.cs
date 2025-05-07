using DAL.Contracts;
using DAL.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class GeneradorDeTicket
    {
        private readonly INumeroTicketRepository numeroTicketRepository;

        public GeneradorDeTicket()
        {
            numeroTicketRepository = FactoryDao.NumeroTicketRepository;
        }

        private int ObtenerProximoNumero(string prefijo)
        {
            DateTime currentDate = DateTime.Today;
            int proximoNumero = numeroTicketRepository.ObtenerProximoNumero(currentDate, prefijo);
            numeroTicketRepository.ActualizarNumeroTicket(currentDate, proximoNumero + 1, prefijo);
            return proximoNumero;
        }

        public string GenerarNumeroDeTicket(string inputPrefijo)
        {
            string prefijo = inputPrefijo ?? "";
            int proximoNumero = ObtenerProximoNumero(prefijo);
            return $"{prefijo}-{proximoNumero:D4}"; // Formato de cuatro dígitos con prefijo
        }
    }
}
