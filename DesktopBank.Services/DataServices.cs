using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;

namespace DesktopBank.Services
{
    public class DataServices
    {
        
        public void AgregarUsuario() { 
        // Datos de conexión a la base de datos
        const string connectionString = "Data Source=sql.bsite.net\\MSSQL2016;User ID=nojedaistic_DesktopBank;Password=********;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        // Datos del usuario a agregar
        string nombre = "Juan";
        string apellido = "Pérez";
        string usuario = "juanperez";
        string cuil = "20999999993";
        string email = "juanperez@juan.com";
        

           
            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Abrir la conexión

                    // Consulta SQL para insertar un nuevo usuario
                    string query = $"INSERT INTO Users (ClientName, ClientSurname, ClientCUIL, ClientEmail) VALUES ('{nombre}', '{apellido}', '{usuario}', '{cuil}', '{email}')";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery(); // Ejecutar la consulta
                        Console.WriteLine("Usuario agregado correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al agregar usuario: {ex.Message}");
                }
                finally
                {
                connection.Close(); // Cerrar la conexión
                }
            }
        }

    }
}
