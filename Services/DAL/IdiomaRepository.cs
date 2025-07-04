﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

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
            try
            {
                string cultura = Thread.CurrentThread.CurrentCulture.Name; // Ejemplo: "es-ES"

                string localPath = $"{path}.{cultura}";

                using (StreamReader sr = new StreamReader(localPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] strings = line.Split('=');
                        string key = strings[0];
                        string value = strings[1];

                        if (key.ToLower() == word.ToLower())
                        {
                            //Tengo una palabra encontrada KEY
                            return value;
                        }
                    }
                }
                // Si no se encuentra la palabra, lanza una excepción
                throw new KeyNotFoundException($"La palabra '{word}' no fue encontrada en el archivo de idioma para la cultura '{cultura}'.");
            }

            catch (FileNotFoundException ex)
            {
                // Manejo de excepciones para archivo no encontrado
                throw new FileNotFoundException($"El archivo de idioma para la cultura '{Thread.CurrentThread.CurrentCulture.Name}' no fue encontrado.", ex);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                throw new Exception($"Error al traducir la palabra '{word}': {ex.Message}", ex);
            }

        }
    }
}
