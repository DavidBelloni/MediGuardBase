using Services.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL
{
    public sealed class IdiomaService
    {
        private readonly static IdiomaService _instance = new IdiomaService();

        public static IdiomaService Current
        {
            get
            {
                return _instance;
            }
        }

        private IdiomaService()
        {
            //Implent here the initialization of your singleton
        }


        public string Traducir(string word)
        {
            try
            {
                return IdiomaRepository.Current.Traducir(word);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                // Puedes registrar el error o lanzar una excepción personalizada
                throw new Exception("Error al traducir la palabra.", ex);
            }

        }

    }
}
