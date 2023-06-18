using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Controller
{
    public class MainController
    {
        private Thread nt;

        public void initFormAdmin()
        {
            nt = new Thread(novoform_gestao);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void initFormCliente()
        {
            nt = new Thread(novoform_cliente);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void initFormAtendimento()
        {
            nt = new Thread(novoForm_Atendimento);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void initFormCinema()
        {
            nt = new Thread(novoForm_Cinema);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void initFormFilmes()
        {
            nt = new Thread(novoForm_Filmes);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void initFormPrincipal()
        {
            nt = new Thread(novoForm_Dashboard);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void initFormSessoes()
        {
            nt = new Thread(novoForm_Sessoes);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        //form admin
        private void novoform_gestao()
        {
            Application.Run(new FormAdmin());
        }

        private void novoForm_Dashboard()
        {
            Application.Run(new FormMenu());
        }
        //form cliente
        private void novoform_cliente()
        {
            Application.Run(new FormCliente());
        }

        //form atendimento
        private void novoForm_Atendimento()
        {
            Application.Run(new FormAtendimento());
        }

        //form cinema
        private void novoForm_Cinema()
        {
            Application.Run(new FormCinema());
        }

        //form filmes
        private void novoForm_Filmes()
        {
            Application.Run(new FormFilmes());
        }

        private void novoForm_Sessoes()
        {
            Application.Run(new FormSessoes());
        }

        public void mostrarOpcoesSaida(PictureBox pbSair)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem itemAlterarUser = new ToolStripMenuItem("Alterar Utilizador");
            itemAlterarUser.Click += tsAlterarUser_Click;
            menu.Items.Add(itemAlterarUser);

            ToolStripMenuItem itemSair = new ToolStripMenuItem("Sair");
            itemSair.Click += tsSair_Click;
            menu.Items.Add(itemSair);

            menu.Show(pbSair, 0, pbSair.Height);
        }

        private void tsAlterarUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem a certeza que deseja alterar o utilizador?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void tsSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem a certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
