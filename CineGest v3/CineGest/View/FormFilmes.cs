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
    public partial class FormFilmes : Form
    {
        private Filme controladorFilme;
        private MainController mainController;
        public FormFilmes()
        {
            InitializeComponent();
            controladorFilme = new Filme();
            mainController = new MainController();

            Load += FormFilmes_Load;

            comboBoxFilmes.SelectedIndexChanged += comboBoxFilmes_SelectedIndexChanged;
        }

        private void FormFilmes_Load(object sender, EventArgs e)
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
            controladorFilme.AdicionarItemsComboBox(comboBoxFilmes);
            controladorFilme.AdicionarItemsComboBox(comboBoxAlterarFilmes);
        }

        private void comboBoxFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // IFs para quando as cenas forem selecionadas
        }

        private void comboBoxAlterarFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // IFs para quando as cenas forem selecionadas
        }

        private void cbAlterarFilmeAtivo_CheckedChanged(object sender, EventArgs e)
        {
            bool editarFilmeAtivoChecked = cbAlterarFilmeAtivo.Checked;

            if (editarFilmeAtivoChecked)
            {
                //adicionar o campo à table selected
            }
            else
            {
                //nada acontece
            }
        }

        private void cbCriarFilmeAtivo_CheckedChanged(object sender, EventArgs e)
        {
            bool adicionarFilmeAtivoChecked = cbCriarFilmeAtivo.Checked;

            if (adicionarFilmeAtivoChecked)
            {
                //adicionar o campo à table selected
            }
            else
            {
                //nada acontece
            }
        }

        private void btnAdicionarFilme_Click(object sender, EventArgs e)
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
    }
}
