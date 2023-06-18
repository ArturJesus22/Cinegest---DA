using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace WindowsFormsApp1.Controller
{
    public class Admin
    {
        public void AdicionarItemsComboBox(ComboBox comboBox)
        {

            string[] cargos = new string[]
            {
                "Administrador", "Funcionário"
            };

            comboBox.Items.AddRange(cargos);
        }


        public static void RegistarUsuario(string utilizador, string password, string permissoes)
        {
            string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFilePath = Path.Combine(baseDirectory, @"CineGest v3\CineGest\CineGest.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True";


            string query = "INSERT INTO Login (Utilizador, Password, Permissoes) VALUES (@Utilizador, @Password, @Permissoes)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Utilizador", utilizador);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Permissoes", permissoes);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}



