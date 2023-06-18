using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Threading;
using WindowsFormsApp1.View;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1
{
    public partial class FormMenu : Form
    {
        private MainController mainController;

        public FormMenu()
        {
            InitializeComponent();
            mainController = new MainController();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string dia = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lb_data.Text = dia;
            string permissao = DBConnection.permissaoUsuario;
            string username = FormLogin.username_global;

            txtUsername.Text = username;

            if (permissao == "1")
            {
                lblgestao.Visible = false;
                pbGestao.Visible = false;
                txtTipoUser.Text = "Funcionário";
            }
            else if (permissao == "2")
            {
                lblgestao.Visible = true;
                pbGestao.Visible = true;
                txtTipoUser.Text = "Administrador";
            } 
            
        }
    
        private void lblAtendimento_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormAtendimento();
        }

        private void labelSessoes_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormSessoes();
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

        private void pbSair_Click(object sender, EventArgs e)
        {
            mainController.mostrarOpcoesSaida(pbSair);
        }


        private void btnAdicionarBilhete_Click(object sender, EventArgs e)
        {

        }

    }
}



