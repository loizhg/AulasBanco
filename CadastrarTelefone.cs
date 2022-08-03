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

        public void AdicionarTelefone()
        {
            Console.WriteLine("Você quer adicionar um numero para qual usuário? ");
            Console.WriteLine("\t - Favor inserir o id do usuário, se não souber liste os mesmos na opção anterior.");
            int IDPesquisa = Convert.ToInt32(Console.ReadLine());

            //procurar
            CadastrarPessoa procurar = new CadastrarPessoa();
            bool existeIDQuery = procurar.SelecionarPessoaID(IDPesquisa);



            if (existeIDQuery == true) 
            {
                Console.WriteLine("existe o id");
                string numero;
                Console.WriteLine("digite o numero : ");
                numero = Convert.ToString(Console.ReadLine());

                // comando sql
                cmd.CommandText = "insert into Telefone (Id_Pessoa, Numero) values (@id_Pessoa, @numero)";

                using (var sql = new SqlConnection())
                {
                    //parametros
                    cmd.Parameters.AddWithValue("@id_Pessoa", IDPesquisa);
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
            else 
            {
                Console.WriteLine("nao existe o id");
            }
            
        }






    }
}
