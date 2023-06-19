using System;
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
    internal class Filme
    {
        public string NomeFilme { get; set; }
        public TimeSpan Duracao { get; set; }
        public bool Ativo { get; set; }

        //Categorias de filmes para adicionar às comboboxes
        public void AdicionarItemsComboBox(ComboBox comboBox)
        {
            string[] categorias = new string[]
            {
                "Comédia", "Sci-fi", "Terror", "Romance", "Acção", "Thriller",
                "Drama", "Mistério", "Crime", "Aventura", "Fantasia", "Animação"
            };
            comboBox.Items.Clear();
            comboBox.Items.AddRange(categorias);
        }
        public void AdicionarFilme(string nome, int duracao, bool estado, string categoriaFilme)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            string queryCount = "SELECT COUNT(*) FROM Sala";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryCount, connection);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                if (count > 0)
                {
                    string query_filme = "INSERT INTO Filme (Nome, Duracao, Activo, Categoria) VALUES (@Nome, @Duracao, @Activo, @Categoria)";

                    using (SqlConnection connectionSala = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command_filme = new SqlCommand(query_filme, connectionSala))
                        {
                            command_filme.Parameters.AddWithValue("@Nome", nome);
                            command_filme.Parameters.AddWithValue("@Duracao", duracao);
                            command_filme.Parameters.AddWithValue("@Activo", estado ? "Sim" : "Não");
                            command_filme.Parameters.AddWithValue("@Categoria", categoriaFilme);

                            connectionSala.Open();
                            command_filme.ExecuteNonQuery();

                            MessageBox.Show("Filme registado com sucesso!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não é possível criar Filme, não existem Salas registadas.");
                }
            }
        }

        public void gridviewUpdateFilmes(DataGridView dataGridView)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Filme", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
                dataGridView.ClearSelection();
                dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
            }
        }

        public void AlterarFilme(string novoNomeFilme, string novaCategoria, int novaDuracao, bool novoEstado, DataGridViewRow selectedRow)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            string query = "UPDATE Filme SET Nome = @NovoNome, Duracao = @Duracao, Activo = @Activo, Categoria = @Categoria WHERE Nome = @Nome";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string nomeFilmeAtual = selectedRow.Cells[1].Value.ToString();

                    command.Parameters.AddWithValue("@NovoNome", novoNomeFilme);
                    command.Parameters.AddWithValue("@Nome", nomeFilmeAtual);
                    command.Parameters.AddWithValue("@Duracao", novaDuracao);
                    command.Parameters.AddWithValue("@Activo", novoEstado ? "Sim" : "Não");
                    command.Parameters.AddWithValue("@Categoria", novaCategoria);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Filme alterado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível alterar o filme");
                    }
                }
            }
        }
    }
}
   