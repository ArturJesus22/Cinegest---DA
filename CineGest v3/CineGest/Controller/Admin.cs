using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Reflection;
using System.ComponentModel;
using WindowsFormsApp1.CineGestDataSetTableAdapters;
using System.Data;

namespace WindowsFormsApp1.Controller
{
    public class Admin
    {
        public void AdicionarItemsComboBox(ComboBox cbPerms)
        {
            string[] cargos = new string[]
            {
                "1 - Funcionário", "2 - Administrador"
            };
            cbPerms.Items.Clear();
            cbPerms.Items.AddRange(cargos);
        }


        public static void RegistarUsuario(string utilizador, string password, string permissoes)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            string query = "INSERT INTO Login (Utilizador, Password, Permissoes) VALUES (@Utilizador, @Password, @Permissoes)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Utilizador", utilizador);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Permissoes", permissoes);
                    MessageBox.Show("Registo de usuário sucedido.");

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void gridviewUpdateUsers(DataGridView dataGridView)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM login", con);
                DataTable dt = new DataTable(); 
                da.Fill(dt); 
                dataGridView.DataSource = dt; 
                dataGridView.ClearSelection();
                dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
            }
        }

        public void gridviewUpdateCinema(DataGridView dataGridView)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM cinema", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
                dataGridView.ClearSelection();
                dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
            }
        }
        public static void AlterarCinema(string novoNomeCinema, string novaMorada, string novoEmail, DataGridViewRow selectedRow)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            string query = "UPDATE Cinema SET Nome = @NovoNome, Email = @NovoEmail, Morada = @NovaMorada WHERE Nome = @Nome";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string NomeCinema = selectedRow.Cells[1].Value.ToString();

                    command.Parameters.AddWithValue("@NovoNome", novoNomeCinema);
                    command.Parameters.AddWithValue("@Nome", NomeCinema);
                    command.Parameters.AddWithValue("@NovaMorada", novaMorada);
                    command.Parameters.AddWithValue("@NovoEmail", novoEmail);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cinema alterado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível alterar o cinema");
                    }
                }
            }
        }
        public static void AlterarUser(string novoNomeUser, string novaPassword, string NovasPerms, DataGridViewRow selectedRow)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            string query = "UPDATE Login SET Utilizador = @NovoNome, Password = @NovaPassword, Permissoes = @NovasPerms WHERE Utilizador = @Nome";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string NomeUser = selectedRow.Cells[1].Value.ToString();

                    command.Parameters.AddWithValue("@NovoNome", novoNomeUser);
                    command.Parameters.AddWithValue("@Nome", NomeUser);
                    command.Parameters.AddWithValue("@NovaPassword", novaPassword);
                    command.Parameters.AddWithValue("@NovasPerms", NovasPerms);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Utilizador alterado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível alterar o utilizador");
                    }
                }
            }
        }
    }
}



