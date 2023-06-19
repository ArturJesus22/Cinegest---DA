using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View
{
    public partial class FormAtendimento : Form
    {
        private MainController mainController;
        private Sessao sessaoController;
        public FormAtendimento()
        {
            InitializeComponent();
            mainController = new MainController();
            sessaoController = new Sessao(); 
        }

        private void FormAtendimento_Load(object sender, EventArgs e)
        {
            string diaDaSemana = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            string data = diaDaSemana;
            lb_data.Text = data;
        }

        private void btnModificarSala_Click(object sender, EventArgs e)
        {
            mainController.gerarColunaseLinhas(cbEscolherSala, tableBtn);
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormPrincipal();
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

        private void FormAtendimento_Load_1(object sender, EventArgs e)
        {
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

            sessaoController.AdicionarItemsComboBoxSalas(cbEscolherSala);
            mainController.AdicionarItemsComboBoxSessoes(cbEscolherSessao);
        }
    }
}
