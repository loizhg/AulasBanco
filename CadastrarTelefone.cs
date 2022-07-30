using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace AulasBanco
{
    class CadastrarTelefone
    {

        DB_Conect conexao = new DB_Conect();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public void AdicionarTelefone(
         int id_Pessoa,
         string numero)
        {
            // comando sql
            cmd.CommandText = "insert into Telefone (Id_Pessoa, Numero) values (@id_Pessoa, @numero)";

            using (var sql = new SqlConnection())
            {
                //parametros
                cmd.Parameters.AddWithValue("@id_Pessoa", id_Pessoa);
                cmd.Parameters.AddWithValue("@numero", numero);


                //conectar com banco
                try
                {
                    //conexao
                    cmd.Connection = conexao.conectar();
                    //executar comando
                    cmd.ExecuteNonQuery();
                    //desconectar
                    conexao.desconectar();
                    //mensagem de erro
                    this.mensagem = "Cadastrado!";
                }
                catch (Exception)
                {
                    this.mensagem = "Erro!";
                }
            }
        }






    }
}
