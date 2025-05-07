using Services.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public sealed class FacadeIdioma
    {
        private readonly static FacadeIdioma _instance = new FacadeIdioma();

        public static FacadeIdioma Current
        {
            get
            {
                return _instance;
            }
        }

        private FacadeIdioma()
        {
            //Implent here the initialization of your singleton
        }

        public static string Traducir(string word)
        {
            return IdiomaService.Current.Traducir(word);
        }
    }
}
