using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace AulasBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ////variaveis para o cadastro de pessoa
            //string nome;
            //string cpf;
            //string rg;
            //DateTime data_nascimento;
            //string naturalidade;


            //variaveis para o cadastro de numeros
            string numero;
            int id_Pessoa;


            //Console.WriteLine("digite o nome : ");
            //nome = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("digite o cpf : ");
            //cpf = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("digite o rg : ");
            //rg = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("digite a data de nascimento : ");
            //data_nascimento = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("digite o naturalidade : ");
            //naturalidade = Convert.ToString(Console.ReadLine());

            ////cadastrar
            //CadastrarPessoa cadastrar = new CadastrarPessoa(nome, cpf, rg, data_nascimento, naturalidade);

            ////listar
            //CadastrarPessoa listar = new CadastrarPessoa();
            //listar.ListarPessoas();

            ////atualizar
            //CadastrarPessoa atualizar = new CadastrarPessoa();
            //atualizar.AtualizarPessoa(nome, cpf, rg, data_nascimento, naturalidade);

            ////procurar
            //CadastrarPessoa procurar = new CadastrarPessoa();
            //procurar.SelecionarPessoa();

            ////deletar
            //CadastrarPessoa deletar = new CadastrarPessoa();
            //deletar.DeletarPessoa();


            Console.WriteLine("digite o id_Pessoa :   ");
            id_Pessoa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o numero : ");
            numero = Convert.ToString(Console.ReadLine());

            //cadastrar numero
            CadastrarTelefone adicionarTelefone = new CadastrarTelefone();
            adicionarTelefone.AdicionarTelefone(id_Pessoa, numero);


        }
    }
}
