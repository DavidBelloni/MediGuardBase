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

        public static IPatientRepository PatientRepository
        {
            get
            {
                if (backendType == (int)BackendType.Memory)
                    return DAL.Implementation.Memory.PatientRepository.Current;
                else
                    return DAL.Implementation.SqlServer.PatientRepository.Current;
            }
        }
    }

    internal enum BackendType
    {
        Memory,
        SqlServer
    }

}
