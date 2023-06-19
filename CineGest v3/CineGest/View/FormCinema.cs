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
        private Sala controllerSala;
        public FormCinema()
        {
            InitializeComponent();
            mainController = new MainController();
            controllerSala = new Sala();
        }

        private void btnAdicionarSala_Click(object sender, EventArgs e)
        {
            decimal colunas = updownColunas.Value; 
            decimal linhas = updownLinhas.Value;
            string nomeSala = txtNomeSala.Text;


            if (colunas == 0 && linhas == 0)
            {
                MessageBox.Show("A quantidade de linhas e colunas têm de ser maior do que 0!");
            }
            else {
                try
                {
                    Sala.RegistarSala(nomeSala, colunas, linhas);
                    controllerSala.gridviewUpdateSalas(dataGridView_Salas);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        private void FormCinema_Load(object sender, EventArgs e)
        {
            this.salaTableAdapter.Fill(this.cineGestDataSet_Salas.Sala);
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

        private void dataGridView_Salas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Salas.Rows[e.RowIndex];

                txtNomeSala.Text = row.Cells[1].Value.ToString();
                updownColunas.Value = Convert.ToDecimal(row.Cells[2].Value);
                updownLinhas.Value = Convert.ToDecimal(row.Cells[3].Value);

            }
        }
    }
}
