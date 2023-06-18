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
    public partial class FormAdmin : Form
    {
        private MainController mainController;
        public FormAdmin()
        {
            InitializeComponent();
            mainController = new MainController();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
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

        private void bt_registaruser_Click(object sender, EventArgs e)
        {
            string utilizador = txt_usuario.Text.Trim();
            string password = txt_password.Text.Trim();
            string permissoes = txtpermissao.Text.Trim();

            if (!string.IsNullOrEmpty(utilizador) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(permissoes))
            {
                try
                {
                    Admin.RegistarUsuario(utilizador, password, permissoes);
                    MessageBox.Show("Registo de usuário sucedido.");
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
    }
}
