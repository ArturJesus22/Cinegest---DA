using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View
{
    public partial class FormCliente : Form
    {
        private MainController mainController;
        private Cliente clienteController;
        public FormCliente()
        {
            InitializeComponent();
            mainController = new MainController();
            clienteController = new Cliente();
        }

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {
            string numFiscal = txtNIF.Text;
            string nome = txtNome.Text;
            string morada = txtMorada.Text;

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(morada) && !string.IsNullOrEmpty(numFiscal))
            {
                try
                {
                    Cliente.RegistarCliente(numFiscal, nome, morada);
                    clienteController.gridviewUpdateClientes(dataGridView_Clientes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registar cliente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormPrincipal();
        }
        private void lblAtendimento_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormAtendimento();
        }

        private void lblCinema_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormCinema();
        }

        private void lblFilmes_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormFilmes();
        }
        private void lblSessoes_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormSessoes();
        }


        public void lblgestao_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormAdmin();
        }

        //Botão de Exit
        private void pbSair_Click(object sender, EventArgs e)
        {
            mainController.mostrarOpcoesSaida(pbSair);
        }

        private void btnModificarCliente_Click_1(object sender, EventArgs e)
        {

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.cineGestDataSet1.Cliente);
            string dia = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lb_data.Text = dia;
            string username = FormLogin.username_global;
            string conversao = "";
            string permissao = DBConnection.permissaoUsuario;
            string cinema = mainController.getCinema();

            if (permissao == "1")
            {
                lblgestao.Visible = false;
                pbGestao.Visible = false;
                conversao = "Funcionário";
            }
            else if (permissao == "2")
            {
                lblgestao.Visible = true;
                pbGestao.Visible = true;
                conversao = "Administrador";
            }

            string info = username + " (" + conversao + ")" + " " + "@" + " " + cinema;
            lblInfo.Text = info;
        }

        private void dataGridView_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Clientes.Rows[e.RowIndex];

                txtNIF.Text = row.Cells[1].Value.ToString(); // Coluna 2
                txtNome.Text = row.Cells[2].Value.ToString(); // Coluna 3
                txtMorada.Text = row.Cells[3].Value.ToString(); // Coluna 4
            }
        }

        private void btnModificarCliente_Click_2(object sender, EventArgs e)
        {
            if (dataGridView_Clientes.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataGridView_Clientes.CurrentRow;


                string novoNomeCliente = txtNome.Text;
                string novaMorada = txtMorada.Text;
                string novoNIF = txtNIF.Text;

                Cliente cliente = new Cliente();
                Cliente.AlterarCliente(novoNomeCliente, novaMorada, novoNIF, selectedRow);
            }
            clienteController.gridviewUpdateClientes(dataGridView_Clientes);
        }
    }
}
