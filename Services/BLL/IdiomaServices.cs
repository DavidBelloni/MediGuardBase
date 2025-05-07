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
            return IdiomaRepository.Current.Traducir(word);
        }

    }
}
