using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TicketNumberGenerator
    {
        private static int GetNextTicketNumber()
        {
            // Aquí deberías implementar la lógica para obtener el siguiente número de ticket desde la base de datos
            // Por ahora, vamos a simularlo con un valor incremental
            int nextNumber = 1;

            // Lógica para obtener el siguiente número de ticket desde la base de datos
            // string commandText = "SELECT MAX(TicketNumber) FROM Patients";
            // using (SqlConnection conn = new SqlConnection(conString))
            // {
            //     using (SqlCommand cmd = new SqlCommand(commandText, conn))
            //     {
            //         conn.Open();
            //         var result = cmd.ExecuteScalar();
            //         if (result != DBNull.Value)
            //         {
            //             string lastTicket = result.ToString();
            //             nextNumber = int.Parse(lastTicket) + 1;
            //         }
            //     }
            // }

            return nextNumber;
        }

        public static string GenerateTicketNumber()
        {
            int nextNumber = GetNextTicketNumber();
            return $"{nextNumber:D4}"; // Formato de cuatro dígitos
        }
    }
}
