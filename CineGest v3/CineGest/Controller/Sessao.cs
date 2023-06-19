using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Sessao
    {
        public DateTime DataHora { get; set; }
        public float Preco { get; set; }

        public void AdicionarItemsComboBoxSalas(ComboBox comboBox)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            string query = "SELECT Nome, Colunas, Filas FROM Sala";


            List<string> sessoesCriadas = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string item = reader.GetString(0);
                            sessoesCriadas.Add(item);
                        }
                    }
                }
            }
            comboBox.Items.Clear();
            comboBox.Items.AddRange(sessoesCriadas.ToArray());
        }

        public void AdicionarItemsComboBoxFilmes(ComboBox comboBox)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            string query = "SELECT Nome FROM Filme WHERE Activo = 'Sim'";

            List<string> filmesCriados = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nomeFilme = reader.GetString(0);
                    filmesCriados.Add(nomeFilme);
                }

                reader.Close();
                connection.Close();
            }
            comboBox.Items.Clear();
            comboBox.Items.AddRange(filmesCriados.ToArray());
        }

        public void AdicionarSessao(DateTime horaSessao, string valorBilhete, string filmeSelecionado, string salaSelecionada)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            string queryCount = "SELECT COUNT(*) FROM Sessao";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryCount, connection);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                if (count == 0) 
                {
                    string query_filme = "INSERT INTO Sessao (DataHora, Preco, Filme, Sala) VALUES (@DataHora, @Preco, @Filme, @Sala)";

                    using (SqlConnection connectionSala = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command_filme = new SqlCommand(query_filme, connectionSala))
                        {
                            command_filme.Parameters.AddWithValue("@DataHora", horaSessao);
                            command_filme.Parameters.AddWithValue("@Preco", valorBilhete);
                            command_filme.Parameters.AddWithValue("@Filme", filmeSelecionado);
                            command_filme.Parameters.AddWithValue("@Sala", salaSelecionada);

                            connectionSala.Open();
                            command_filme.ExecuteNonQuery();

                            MessageBox.Show("Sessão registada com sucesso!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível registar a sessão, por favor tente novamente.");
                }
            }
        }

        public void gridviewUpdateSessoes(DataGridView dataGridView)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Sessao", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
                dataGridView.ClearSelection();
                dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
            }
        }

    }
}
