using Services.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public static class IdiomaExtension
    {
        // Gracias a esto, puedo llamar a traducir desde cualquier lugar de mi programa
        public static string Traducir(this string word)
        {
            return IdiomaService.Current.Traducir(word);
        }
    }
}
