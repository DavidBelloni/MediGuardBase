using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Services.DAL
{
    public sealed class IdiomaRepository
    {
        #region Singleton
        private readonly static IdiomaRepository _instance = new IdiomaRepository();

        public static IdiomaRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private IdiomaRepository()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        private static string folderPath = ConfigurationManager.AppSettings["IdiomaFolderPath"];

        private static string fileName = ConfigurationManager.AppSettings["IdiomaFileName"];

        private static string path = default;
        static IdiomaRepository()
        {
            path = Path.Combine(folderPath, fileName);
        }

        public string Traducir(string word)
        {
            // Obtener la cultura actual del sistema o una cultura predeterminada
            string cultura = CultureInfo.CurrentCulture.Name; // Ejemplo: "es-ES"

            string localPath = $"{path}.{cultura}";

            if (!File.Exists(localPath))
            {
                throw new FileNotFoundException($"El archivo de idioma para la cultura '{cultura}' no fue encontrado.");
            }

            using (StreamReader sr = new StreamReader(localPath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] strings = line.Split('=');
                    if (strings.Length != 2) continue; // Validar formato correcto

                    string key = strings[0];
                    string value = strings[1];

                    if (key.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        return value;
                    }
                }
            }

            throw new KeyNotFoundException($"La palabra '{word}' no fue encontrada en el archivo de idioma para la cultura '{cultura}'.");
        }

        // METODO VIEJO DONDE SE PASABA LA CULTURA
        //public string Traducir(string word, string cultura)
        //{
        //    string localPath = $"{path}.{cultura}";

        //    using (StreamReader sr = new StreamReader(localPath))
        //    {
        //        while (!sr.EndOfStream)
        //        {
        //            string line = sr.ReadLine();

        //            string[] strings = line.Split('=');
        //            string key = strings[0];
        //            string value = strings[1];

        //            if (key.ToLower() == word.ToLower())
        //            {
        //                //Tengo una palabra encontrada KEY
        //                return value;
        //            }
        //        }
        //    }

        //    throw new Exception("Custom Exception");

        //}



    }
}
