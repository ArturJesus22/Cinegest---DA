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
    public partial class FormCinema : Form
    {
        private MainController mainController;
        public FormCinema()
        {
            InitializeComponent();
            mainController = new MainController();
        }

        private void btnAdicionarSala_Click(object sender, EventArgs e)
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

        private void FormCinema_Load(object sender, EventArgs e)
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
