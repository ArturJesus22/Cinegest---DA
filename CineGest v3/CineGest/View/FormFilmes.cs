using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View
{
    public partial class FormFilmes : Form
    {
        private Filme Filme;
        private MainController mainController;
        public FormFilmes()
        {
            InitializeComponent();
            Filme = new Filme();
            mainController = new MainController();

            Load += FormFilmes_Load;

            comboBoxFilmes.SelectedIndexChanged += comboBoxFilmes_SelectedIndexChanged;
        }

        private void FormFilmes_Load(object sender, EventArgs e)
        {
            this.filmeTableAdapter.Fill(this.cineGestDataSet_Filmes.Filme);
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
            Filme.AdicionarItemsComboBox(comboBoxFilmes);
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
            // Obter os valores dos controles
            string nomeFilme = txtAdicionarNomeFilme.Text;
            string categoriaFilme = comboBoxFilmes.SelectedItem.ToString();
            int duracaoFilme = (int)updownDuracao.Value;
            bool estadoFilme = cbCriarFilmeAtivo.Checked;

            // Chamar o controlador para salvar os dados na base de dados

            if (!string.IsNullOrEmpty(nomeFilme) && !string.IsNullOrEmpty(categoriaFilme))
            {
                try
                {
                    Filme.AdicionarFilme(nomeFilme, duracaoFilme, estadoFilme, categoriaFilme);
                    Filme.gridviewUpdateFilmes(dataGridView_Filmes);
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



            // Limpar os controles após adicionar o filme
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtAdicionarNomeFilme.Text = string.Empty;
            comboBoxFilmes.SelectedIndex = -1;
            updownDuracao.Value = 0;
            cbCriarFilmeAtivo.Checked = false;
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

        private void dataGridView_Filmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Filmes.Rows[e.RowIndex];

                txtAdicionarNomeFilme.Text = row.Cells[0].Value.ToString();

                string categoria = row.Cells[1].Value.ToString();
                if (comboBoxFilmes.Items.Contains(categoria))
                {
                    comboBoxFilmes.SelectedItem = categoria;
                }

                updownDuracao.Value = Convert.ToInt32(row.Cells[2].Value);
                cbCriarFilmeAtivo.Checked = row.Cells[3].Value.ToString() == "Sim";
            }
        }

        private void dataGridView_Filmes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Filmes.Rows[e.RowIndex];

                txtAdicionarNomeFilme.Text = row.Cells[1].Value.ToString();
                updownDuracao.Value = Convert.ToDecimal(row.Cells[2].Value);
                cbCriarFilmeAtivo.Checked = row.Cells[3].Value.ToString() == "Sim";
                comboBoxFilmes.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnModificarFilme_Click(object sender, EventArgs e)
        {
            if (dataGridView_Filmes.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataGridView_Filmes.CurrentRow;


                string novoNomeFilme = txtAdicionarNomeFilme.Text;
                string novaCategoria = comboBoxFilmes.SelectedItem.ToString();
                int novaDuracao = Convert.ToInt32(updownDuracao.Value);
                bool novoEstado = cbCriarFilmeAtivo.Checked;

                Filme filme = new Filme();
                Filme.AlterarFilme(novoNomeFilme, novaCategoria, novaDuracao, novoEstado, selectedRow);
            }
            Filme.gridviewUpdateFilmes(dataGridView_Filmes);
        }
    }
}
