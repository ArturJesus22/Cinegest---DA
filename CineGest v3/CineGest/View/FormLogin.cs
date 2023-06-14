using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        Thread nt;
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void imgOlho_Click(object sender, EventArgs e)
        {
                txtPassword.UseSystemPasswordChar = false;
                imgOlho.Visible = false;
                picture_esconderpass.Visible = true;  
        }

        private void picture_esconderpass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            imgOlho.Visible = true;
            picture_esconderpass.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem a certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnSairLogin_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem a certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoform); //inicia um novo processo, que é o form
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void novoform() //método novoform, que corresponde ao ínicio do formulário principal
        {
            Application.Run(new FormMenu());
        }
    }
}
