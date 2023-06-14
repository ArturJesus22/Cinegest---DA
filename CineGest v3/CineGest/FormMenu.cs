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
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;


namespace WindowsFormsApp1
{
    public partial class FormMenu : Form
    {
        private System.Windows.Forms.Label lblSelecionada;
        public FormMenu()
        {
            InitializeComponent();
            ucHome uc = new ucHome();
            adicionarUserControl(uc);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string diaDaSemana = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            string data = diaDaSemana;
            lb_data.Text = data;
        }
        private void adicionarUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            painelContentor.Controls.Clear();
            painelContentor.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            ucHome uc = new ucHome();
            adicionarUserControl(uc);
        }
        private void lblAtendimento_Click(object sender, EventArgs e)
        {
            ucAtendimento uc = new ucAtendimento();
            adicionarUserControl(uc);
        }

        private void lblCinema_Click(object sender, EventArgs e)
        {
            ucCinema uc = new ucCinema();
            adicionarUserControl(uc);
        }
        private void lblFilmes_Click(object sender, EventArgs e)
        {
            ucFilmes uc = new ucFilmes();
            adicionarUserControl(uc);
        }
        private void lblSessoes_Click(object sender, EventArgs e)
        {
            ucSessoes uc = new ucSessoes();
            adicionarUserControl(uc);
        }
        private void lblClientes_Click(object sender, EventArgs e)
        {
            ucClientes uc = new ucClientes();
            adicionarUserControl(uc);
        }

        private void Label_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Label lblClick = (System.Windows.Forms.Label)sender;

            if (lblSelecionada != null)
            {
                lblSelecionada.Font = new Font(lblSelecionada.Font, lblSelecionada.Font.Style & ~FontStyle.Bold);
            }

            lblClick.Font = new Font(lblClick.Font, lblClick.Font.Style | FontStyle.Bold);
            lblSelecionada = lblClick;
        }

        private void pbSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem a certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pbCinema_Click(object sender, EventArgs e)
        {
            ucCinema uc = new ucCinema();
            adicionarUserControl(uc);
        }

        private void pbFilmes_Click(object sender, EventArgs e)
        {
            ucFilmes uc = new ucFilmes();
            adicionarUserControl(uc);
        }

        private void pbSessoes_Click(object sender, EventArgs e)
        {
            ucSessoes uc = new ucSessoes();
            adicionarUserControl(uc);
        }

        private void pbClientes_Click(object sender, EventArgs e)
        {
            ucClientes uc = new ucClientes();
            adicionarUserControl(uc);
        }

        private void lblUpperMenu_Click(object sender, EventArgs e)
        {

        }
    }
}

