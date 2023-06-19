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
    public partial class FormSessoes : Form
    {
        private MainController mainController;
        private Sessao sessaoController;
        public FormSessoes()
        {
            InitializeComponent();
            mainController = new MainController();
            sessaoController = new Sessao();
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

        private void btnAdicionarSessão_Click(object sender, EventArgs e)
        {
            //Terá de guardar DataHora, Preço dos Bilhetes, Filme que vai passar e a Sala

            string salaSelecionada = comboBoxSalas.SelectedItem.ToString();
            string filmeSelecionado = comboBoxFilmes.SelectedItem.ToString();
            string valorBilhete = txtValorBilhete.Text;
            DateTime horaSessao = dataPicker.Value.Date + horaPicker.Value.TimeOfDay;

            if (!string.IsNullOrEmpty(salaSelecionada) && !string.IsNullOrEmpty(filmeSelecionado))
            {
                try
                {
                    sessaoController.AdicionarSessao(horaSessao, valorBilhete, filmeSelecionado, salaSelecionada);
                    sessaoController.gridviewUpdateSessoes(dataGridView_Users);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registar o filme: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
        }

        private void FormSessoes_Load(object sender, EventArgs e)
        {
            this.sessaoTableAdapter.Fill(this.cineGestDataSet2.Sessao);
            string dia = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lb_data.Text = dia;
            string username = FormLogin.username_global;
            string conversao = "";
            string permissao = DBConnection.permissaoUsuario;
            string cinema = mainController.getCinema();

            horaPicker.Format = DateTimePickerFormat.Time;
            horaPicker.ShowUpDown = true;

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

            sessaoController.AdicionarItemsComboBoxSalas(comboBoxSalas);
            sessaoController.AdicionarItemsComboBoxFilmes(comboBoxFilmes);
        }
    }
}
