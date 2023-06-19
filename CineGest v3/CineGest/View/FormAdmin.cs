using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.View
{
    public partial class FormAdmin : Form
    {
        private MainController mainController;
        private Admin administradorController;
        public FormAdmin()
        {
            InitializeComponent();
            mainController = new MainController();
            administradorController = new Admin();

            Load += FormAdmin_Load;
            cbPerms.SelectedIndexChanged += cbPerms_SelectedIndexChanged;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            this.cinemaTableAdapter.Fill(this.cineGestDataSet_Cinema.Cinema);
            this.loginTableAdapter.Fill(this.cineGestDataSet.Login);
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

            administradorController.AdicionarItemsComboBox(cbPerms);
        }

        private void bt_registaruser_Click(object sender, EventArgs e)
        {
            string utilizador = txt_usuario.Text.Trim();
            string password = txt_password.Text.Trim();
            string permissoes = cbPerms.SelectedItem as string;
            string numPermissao;
            if (permissoes == "1 - Funcionário")
            {
               numPermissao = "1";
            }
            else
            { 
                numPermissao = "2";
            }

            if (!string.IsNullOrEmpty(utilizador) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(permissoes))
            {
                try
                {
                    Admin.RegistarUsuario(utilizador, password, numPermissao);
                    administradorController.gridviewUpdateUsers(dataGridView_Users);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registar usuário: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
            

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

        private void lblClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormCliente();

        }

        //Botão de Exit
        private void pbSair_Click(object sender, EventArgs e)
        {
            mainController.mostrarOpcoesSaida(pbSair);
        }

        private void btnCriarCinema_Click(object sender, EventArgs e)
        {
            string nomeCinema = txtNomeCinema.Text;
            string morada = txtMoradaCinema.Text;
            string email = txtEmailCinema.Text;

                try
                {
                    Cinema.RegistarCinema(nomeCinema, email, morada);
                    administradorController.gridviewUpdateCinema(dataGridView1);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao criar o cinema: " + ex.Message);
            }
        }

        private void cbPerms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNomeCinema.Text = row.Cells[0].Value.ToString();
                txtEmailCinema.Text = row.Cells[1].Value.ToString();
                txtMoradaCinema.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dataGridView_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView_Users.Rows[e.RowIndex];

                    txt_usuario.Text = row.Cells[1].Value.ToString();
                    txt_password.Text = row.Cells[2].Value.ToString();
                    cbPerms.Text = row.Cells[3].Value.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                string novoNomeCinema = txtNomeCinema.Text;
                string novaMorada = txtMoradaCinema.Text;
                string novoEmail = txtEmailCinema.Text;

                Admin admin = new Admin();
                Admin.AlterarCinema(novoNomeCinema, novaMorada, novoEmail, selectedRow);
                administradorController.gridviewUpdateCinema(dataGridView1);
            }
            else
                MessageBox.Show("Nenhum cinema selecionado!");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cbPerms.SelectedItem != null)
            {
                DataGridViewRow selectedRow = dataGridView_Users.CurrentRow;
                string novasPerms = cbPerms.SelectedItem.ToString();
                string novoNomeUser = txtNomeCinema.Text;
                string novaPassword = txt_password.Text;

                Admin Admin = new Admin();
                Admin.AlterarUser(novoNomeUser, novaPassword, novasPerms, selectedRow);
                administradorController.gridviewUpdateUsers(dataGridView_Users);
            }
            else
            {
                MessageBox.Show("Nenhuma permissão selecionada!");
            }
        }
    }
}
