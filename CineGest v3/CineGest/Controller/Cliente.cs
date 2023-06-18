using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cliente
    {

        public static void RegistarCliente(string numFiscal, string nome, string morada)
        {

            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            // Query SQL para inserir o cliente na tabela Cliente
            string query = "INSERT INTO Cliente (NumFiscal, Nome, Morada) VALUES (@NumFiscal, @Nome, @Morada)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@NumFiscal", numFiscal);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Morada", morada);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
