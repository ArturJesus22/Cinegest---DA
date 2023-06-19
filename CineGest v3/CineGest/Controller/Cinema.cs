using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Cinema
    {
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }

        public static string cinemaNome;

        public static void RegistarCinema(string nomeCinema, string email, string morada)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";


            int id = 1; // ID que você deseja verificar

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand inserirId = new SqlCommand("SET IDENTITY_INSERT dbo.Cinema ON", connection))
                {
                    inserirId.ExecuteNonQuery();
                }

                string query = "SELECT COUNT(*) FROM Cinema WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Já existe um cinema criado!");
                    }
                    else
                    {
                        using (SqlConnection connection_cinema = new SqlConnection(connectionString))
                        {
                            int id_cinema = 1;

                            string query_cinema = "INSERT INTO Cinema (Id, Nome, Email, Morada) VALUES (@id_cinema, @nomeCinema, @email, @morada)";
                            using (SqlCommand command_cinema = new SqlCommand(query_cinema, connection))
                            {
                                command_cinema.Parameters.AddWithValue("@id_cinema", id_cinema);
                                command_cinema.Parameters.AddWithValue("@nomeCinema", nomeCinema);
                                command_cinema.Parameters.AddWithValue("@email", email);
                                command_cinema.Parameters.AddWithValue("@morada", morada);
                                MessageBox.Show("Cinema registado com sucesso!");
                                cinemaNome = nomeCinema;

                                
                                command_cinema.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }        
        }
    }
}
