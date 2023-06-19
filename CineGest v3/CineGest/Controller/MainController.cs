using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Controller
{
    public class MainController
    {
        private Thread nt;

        public void initFormAdmin()
        {
            nt = new Thread(novoform_gestao);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void initFormCliente()
        {
            nt = new Thread(novoform_cliente);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void initFormAtendimento()
        {
            nt = new Thread(novoForm_Atendimento);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void initFormCinema()
        {
            nt = new Thread(novoForm_Cinema);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void initFormFilmes()
        {
            nt = new Thread(novoForm_Filmes);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void initFormPrincipal()
        {
            nt = new Thread(novoForm_Dashboard);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void initFormSessoes()
        {
            nt = new Thread(novoForm_Sessoes);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        //form admin
        private void novoform_gestao()
        {
            Application.Run(new FormAdmin());
        }

        private void novoForm_Dashboard()
        {
            Application.Run(new FormMenu());
        }
        //form cliente
        private void novoform_cliente()
        {
            Application.Run(new FormCliente());
        }

        //form atendimento
        private void novoForm_Atendimento()
        {
            Application.Run(new FormAtendimento());
        }

        //form cinema
        private void novoForm_Cinema()
        {
            Application.Run(new FormCinema());
        }

        //form filmes
        private void novoForm_Filmes()
        {
            Application.Run(new FormFilmes());
        }

        private void novoForm_Sessoes()
        {
            Application.Run(new FormSessoes());
        }

        public void mostrarOpcoesSaida(PictureBox pbSair)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem itemAlterarUser = new ToolStripMenuItem("Alterar Utilizador");
            itemAlterarUser.Click += tsAlterarUser_Click;
            menu.Items.Add(itemAlterarUser);

            ToolStripMenuItem itemSair = new ToolStripMenuItem("Sair");
            itemSair.Click += tsSair_Click;
            menu.Items.Add(itemSair);

            menu.Show(pbSair, 0, pbSair.Height);
        }

        private void tsAlterarUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem a certeza que deseja alterar o utilizador?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void tsSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem a certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public string getCinema()
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";
            string nomeDoCinema = "";
            string query = "SELECT Nome FROM Cinema WHERE ID = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string cinemaName = reader["Nome"].ToString();

                    nomeDoCinema = cinemaName;
                }

                reader.Close();
                connection.Close();

                return nomeDoCinema;
            }
        }

        public void AdicionarItemsComboBoxSessoes(ComboBox comboBox)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            string query = "SELECT DataHora FROM Sessao";

            List<string> sessoesExistentes = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DateTime sessao = reader.GetDateTime(0);
                    string sessaoString = sessao.ToString();
                    sessoesExistentes.Add(sessaoString);
                }

                reader.Close();
                connection.Close();
            }
            comboBox.Items.Clear();
            comboBox.Items.AddRange(sessoesExistentes.ToArray());
        }

        public void gerarColunaseLinhas(ComboBox cbEscolherSala, TableLayoutPanel tableBtn)
        {

            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";

            string selectedItem = cbEscolherSala.SelectedItem.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = $"SELECT Filas, Colunas FROM Sala WHERE Nome = '{selectedItem}'";
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int linhas = reader.GetInt32(0);
                    int colunas = reader.GetInt32(1);

                    tableBtn.Controls.Clear();
                    tableBtn.ColumnStyles.Clear();
                    tableBtn.RowStyles.Clear();
                    tableBtn.RowCount = linhas;
                    tableBtn.ColumnCount = colunas;

                    for (int row = 0; row < linhas; row++)
                    {
                        tableBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / linhas));

                        for (int col = 0; col < colunas; col++)
                        {
                            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / colunas));

                            Button button = new Button();

                            button.Dock = DockStyle.Fill;

                            button.Name = $"btn_{row}_{col}";

                            button.Click += botaoClicado;

                            tableBtn.Controls.Add(button, col, row);
                        }
                    }
                }

                reader.Close();
                con.Close();
            }
        }
        private void botaoClicado(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.BackColor == ColorTranslator.FromHtml("#5C5C5C"))
            {
                button.BackColor = ColorTranslator.FromHtml("#29BB1D");
            }
            else
            {
                button.BackColor = ColorTranslator.FromHtml("#5C5C5C");
            }
        }
    }
}
