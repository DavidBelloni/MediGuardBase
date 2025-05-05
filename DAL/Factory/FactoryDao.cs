using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL.Implementation.SqlServer;
using DAL.Contracts;

namespace DAL.Factory
{
    public static class FactoryDao
    {
        private static int backendType;

        static FactoryDao()
        {
            backendType = int.Parse(ConfigurationManager.AppSettings["BackendType"]);
        }

        public static IPacienteRepository PacienteRepository
        {
            get
            {
                if (backendType == (int)BackendType.Memory)
                    return DAL.Implementation.Memory.PacienteRepository.Current;
                else
                    return DAL.Implementation.SqlServer.PacienteRepository.Current;
            }
        }

        public static INumeroTicketRepository NumeroTicketRepository
        {
            get
            {
                if (backendType == (int)BackendType.Memory)
                    return DAL.Implementation.Memory.NumeroTicketRepository.Current;
                else
                    return DAL.Implementation.SqlServer.NumeroTicketRepository.Current;
            }
        }

        public static IVisitaRepository VisitaRepository
        {
            get
            {
                if (backendType == (int)BackendType.Memory)
                    return DAL.Implementation.Memory.VisitaRepository.Current;
                else
                    return DAL.Implementation.SqlServer.VisitaRepository.Current;
            }
        }

        public static ITriageRepository TriageRepository
        {
            get
            {
                if (backendType == (int)BackendType.Memory)
                    return DAL.Implementation.Memory.TriageRepository.Current;
                else
                    return DAL.Implementation.SqlServer.TriageRepository.Current;
            }
        }
    }


    internal enum BackendType
    {
        Memory,
        SqlServer
    }

}
