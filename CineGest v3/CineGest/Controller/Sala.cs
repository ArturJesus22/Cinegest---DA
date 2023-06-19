using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Sala
    {
        public string NomeSala { get; set; }
        public int Colunas { get; set; }
        public int Filas { get; set; }

        public static void RegistarSala(string nomeSala, decimal colunas, decimal linhas)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            string queryCount = "SELECT COUNT(*) FROM cinema";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryCount, connection);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                if (count > 0)
                {
                    string query_sala = "INSERT INTO Sala (Nome, Colunas, Filas, Cinema_id) VALUES (@Nome, @Colunas, @Filas, @Id_Cinema)";

                    using (SqlConnection connection_sala = new SqlConnection(connectionString))
                    {
                        int numCinema = 1;

                        using (SqlCommand command_sala = new SqlCommand(query_sala, connection_sala))
                        {
                            connection_sala.Open();
                            command_sala.Parameters.AddWithValue("@Id_Cinema", numCinema);
                            command_sala.Parameters.AddWithValue("@Nome", nomeSala);
                            command_sala.Parameters.AddWithValue("@Colunas", colunas);
                            command_sala.Parameters.AddWithValue("@Filas", linhas);

                            command_sala.ExecuteNonQuery();

                            connection_sala.Close();
                            MessageBox.Show("Sala registada com sucesso!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não é possível criar a sala, não existe cinema registrado.");
                }
            }

        }

        public void gridviewUpdateSalas(DataGridView dataGridView)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Sala", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
                dataGridView.ClearSelection();
                dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
            }
        }
    }
}
