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
        public FormCliente()
        {
            InitializeComponent();
            mainController = new MainController();
        }

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {
            string numFiscal = txtNIF.Text;
            string nome = txtNome.Text;
            string morada = txtMorada.Text;

            if(!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(morada) && !string.IsNullOrEmpty(numFiscal))
            {
                try
                {
                    Cliente.RegistarCliente(numFiscal, nome, morada);
                    MessageBox.Show("Registo de cliente bem sucedido.");
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
            DialogResult resultado = MessageBox.Show("Tem a certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnModificarCliente_Click_1(object sender, EventArgs e)
        {

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            string dia = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lb_data.Text = dia;
            string permissao = DBConnection.permissaoUsuario;


            if (permissao == "1")
            {
                lblgestao.Visible = false;
                pbGestao.Visible = false;
            }
            else if (permissao == "2")
            {
                lblgestao.Visible = true;
                pbGestao.Visible = true;
            }
        }
    }
}
