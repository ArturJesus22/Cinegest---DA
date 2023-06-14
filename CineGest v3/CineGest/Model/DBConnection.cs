using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class DBConnection
    {
      SqlConnection con = new SqlConnection();
       public DBConnection()
       {
          con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True";


       }
       public SqlConnection Conectar()
       {
       if (con.State == System.Data.ConnectionState.Closed)
       {
         con.Open();
       }
                return con;
            }
            public void desconectar()
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }

