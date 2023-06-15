using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Filme
    {       
        public string NomeFilme { get; set; }
        public TimeSpan Duracao { get; set; }
        public bool Ativo { get; set; }

        //Categorias de filmes para adicionar às comboboxes
        public void AdicionarItemsComboBox(ComboBox comboBox)
        {
            string[] categorias = new string[]
            {
                "Comédia", "Sci-fi", "Terror", "Romance", "Acção", "Thriller",
                "Drama", "Mistério", "Crime", "Aventura", "Fantasia", "Animação"
            };

            comboBox.Items.AddRange(categorias);
        }
    }
}
