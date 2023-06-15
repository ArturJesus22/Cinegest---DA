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

namespace WindowsFormsApp1
{
    public partial class ucFilmes : UserControl
    {
        private Filme controladorFilme;

        public ucFilmes()
        {
            InitializeComponent();
            controladorFilme = new Filme();

            Load += ucFilmes_Load;

            comboBoxFilmes.SelectedIndexChanged += comboBoxFilmes_SelectedIndexChanged;
        }

        private void btnAdicionarFilme_Click(object sender, EventArgs e)
        {
            //adicionar o codigo
        }

        private void ucFilmes_Load(object sender, EventArgs e)
        {
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
    }
} 
