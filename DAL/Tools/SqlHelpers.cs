using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Tools
{
        internal static class SqlHelper
        {
            readonly static string conString;

        // Construstor estático que inicializa la cadena de conexión a la base de datos.
       
        static SqlHelper()
            {
                conString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
            }
        // ExecuteNonQuery sirve para ejecutar un comando SQL y devolver el número de filas afectadas.
        // Se recomienda para Update y Deletes
        public static Int32 ExecuteNonQuery(String commandText,
                CommandType commandType, params SqlParameter[] parameters)
            {
                CheckNullables(parameters);

                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(commandText, conn))
                    {
                        // There're three command types: StoredProcedure, Text, TableDirect. The TableDirect 
                        // type is only for OLE DB.  
                        cmd.CommandType = commandType;
                        cmd.Parameters.AddRange(parameters);

                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }

        // CheckNullables es un método privado que verifica si los parámetros son nulos y los establece en DBNull.Value.
        
        private static void CheckNullables(SqlParameter[] parameters)
            {
                foreach (SqlParameter item in parameters)
                {
                    if (item.SqlValue == null)
                    {
                        item.SqlValue = DBNull.Value;
                    }
                }
            }

        // ExecuteScalar sirve para ejecutar un comando SQL y devolver un solo valor.
        // Se utiliza para Insert
        public static Object ExecuteScalar(String commandText,
                CommandType commandType, params SqlParameter[] parameters)
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(commandText, conn))
                    {
                        cmd.CommandType = commandType;
                        cmd.Parameters.AddRange(parameters);

                        conn.Open();
                        return cmd.ExecuteScalar();
                    }
                }
            }

        // ExecuteReader sirve para ejecutar un comando SQL y devolver un SqlDataReader.
        // Se utiliza para Select
        // Aca es importante al usarlo recordar Cerrar la CONEXION
        public static SqlDataReader ExecuteReader(String commandText,
                CommandType commandType, params SqlParameter[] parameters)
            {
                SqlConnection conn = new SqlConnection(conString);

                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    // When using CommandBehavior.CloseConnection, the connection will be closed when the 
                    // IDataReader is closed.
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    return reader;
                }
            }
        }
}
