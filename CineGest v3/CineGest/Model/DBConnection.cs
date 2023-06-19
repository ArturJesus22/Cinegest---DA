using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Data;
using System.Collections;

namespace WindowsFormsApp1.Model
{
    public class DBConnection : FormLogin
    {
        public static string permissaoUsuario;

        public bool DBConnect(string username, string password, out string permissao)
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CineGest.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT COUNT(*) FROM Login WHERE Utilizador = @Utilizador AND Password = @Password";

                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@Utilizador", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        sql = "SELECT Permissoes FROM Login WHERE Utilizador = @Utilizador AND Password = @Password";
                        command = new SqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@Utilizador", username);
                        command.Parameters.AddWithValue("@Password", password);
                        permissao = command.ExecuteScalar()?.ToString();
                        permissaoUsuario = permissao;
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro: " + e.Message);
            }

            permissao = null;
            return false;
        }
    }
}