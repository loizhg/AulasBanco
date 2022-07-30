using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace AulasBanco
{
    public class DB_Conect
    {
        SqlConnection con = new SqlConnection();
        public DB_Conect()
        {
            //colocar o @ na frente é necessário
            con.ConnectionString = @"Data Source=ITELABD13\SQLEXPRESS;Initial Catalog=BancoAula2;Integrated Security=True";

        }

        public SqlConnection conectar()
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
