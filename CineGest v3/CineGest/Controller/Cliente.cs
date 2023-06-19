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
                    MessageBox.Show("Registo de cliente bem sucedido.");
                }
            }
        }

        public void gridviewUpdateClientes(DataGridView dataGridView)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM cliente", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
                dataGridView.ClearSelection();
                dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
            }
        }
        public static void AlterarCliente(string novoNomeCliente, string novaMorada, string novoNIF, DataGridViewRow selectedRow)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            string query = "UPDATE Cliente SET Nome = @NovoNome, NumFiscal = @NovoNIF, Morada = @novaMorada WHERE Nome = @Nome";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string NomeCliente = selectedRow.Cells[2].Value.ToString();

                    command.Parameters.AddWithValue("@NovoNome", novoNomeCliente);
                    command.Parameters.AddWithValue("@Nome", NomeCliente);
                    command.Parameters.AddWithValue("@NovaMorada", novaMorada);
                    command.Parameters.AddWithValue("@NovoNIF", novoNIF);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente alterado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível alterar o cliente");
                    }
                }
            }
        }
    }
}
