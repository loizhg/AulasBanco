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
            /* 
             DECLARAÇÕES DE VARIAVEIS
             */

            //variaveis para o cadastro de pessoa
            string nome;
            string cpf;
            string rg;
            DateTime data_nascimento;
            string naturalidade;

            //variaveis para o cadastro de numeros
            string numero;
            int id_Pessoa;

            //variaveis para uso diverso
            int opcaoUsuario = 0;
            int opcaoTelefone = 0;
            String mensagem = ""; //A MENSAGEM DE ERRO POR PADRÃO DEVE VIR VAZIA NÃO NULLA 


            /*  
             CODIGO A PARTIR DAQUI
             */

            //OPÇÕES PESSOA
            Console.WriteLine("Escolha uma das opções: ");
            Console.WriteLine("\t 1 - cadastrar ");
            Console.WriteLine("\t 2 - listar ");
            Console.WriteLine("\t 3 - atualizar ");
            Console.WriteLine("\t 4 - procurar ");
            Console.WriteLine("\t 5 - deletar ");
            Console.WriteLine("\t 6 - Opções de telefone ");
            Console.WriteLine("\t 7 - sair do sistema ");

            Console.WriteLine("Sua opção? ");
            opcaoUsuario = Convert.ToInt32(Console.ReadLine());


            while (opcaoUsuario != 7)
            {
                if (opcaoUsuario == 1)
                {
                    //solicitações para cadastro
                    Console.WriteLine("digite o nome : ");
                    nome = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("digite o cpf : ");
                    cpf = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("digite o rg : ");
                    rg = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("digite a data de nascimento : ");
                    data_nascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("digite o naturalidade : ");
                    naturalidade = Convert.ToString(Console.ReadLine());

                    //cadastrar
                    CadastrarPessoa cadastrar = new CadastrarPessoa();
                    cadastrar.CadastrarPessoaa(nome, cpf, rg, data_nascimento, naturalidade);
                }

                if (opcaoUsuario == 2)
                {
                    //listar
                    CadastrarPessoa listar = new CadastrarPessoa();
                    listar.ListarPessoas();
                }

                if (opcaoUsuario == 3)
                {
                    Console.WriteLine("Qual o id do usuário que você gostaria de editar? ");
                    int opcaoUsuarioATT = Convert.ToInt32(Console.ReadLine());

                    //solicitações para atualização
                    Console.WriteLine("digite o nome: ");
                    nome = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("digite o cpf: ");
                    cpf = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("digite o rg: ");
                    rg = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("digite a data de nascimento: ");
                    data_nascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("digite o naturalidade: ");
                    naturalidade = Convert.ToString(Console.ReadLine());

                    //atualizar
                    CadastrarPessoa atualizar = new CadastrarPessoa();
                    atualizar.AtualizarPessoa(nome, cpf, rg, data_nascimento, naturalidade, opcaoUsuarioATT);
                }

                if (opcaoUsuario == 4)
                {
                    Console.WriteLine("Você quer pesquisar nomes com que letras? ");
                    string letrasPesquisa = Convert.ToString(Console.ReadLine());

                    //procurar
                    CadastrarPessoa procurar = new CadastrarPessoa();
                    procurar.SelecionarPessoa(letrasPesquisa);
                }

                if (opcaoUsuario == 5)
                {
                    //deletar
                    CadastrarPessoa deletar = new CadastrarPessoa();
                    deletar.DeletarPessoa();
                }

                if (opcaoUsuario == 6)
                {

                    //OPÇÕES TELEFONE
                    Console.WriteLine("Escolha uma das opções: ");
                    Console.WriteLine("\t 1 - cadastrar ");
                    Console.WriteLine("\t 2 - sair da opções de telefones ");

                    Console.WriteLine("Sua opção? ");
                    opcaoTelefone = Convert.ToInt32(Console.ReadLine());

                    while (opcaoTelefone != 2)
                    {
                        if (opcaoTelefone == 1)
                        {
                            //cadastrar numero
                            CadastrarTelefone adicionarTelefone = new CadastrarTelefone();
                            adicionarTelefone.AdicionarTelefone();
                        }
                        Console.WriteLine("Escolha uma das opções: ");
                        Console.WriteLine("\t 1 - cadastrar ");
                        Console.WriteLine("\t 2 - sair da opções de telefones ");

                        Console.WriteLine("Sua opção? ");
                        opcaoTelefone = Convert.ToInt32(Console.ReadLine());
                    }

                }

                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("\t 1 - cadastrar ");
                Console.WriteLine("\t 2 - listar ");
                Console.WriteLine("\t 3 - atualizar ");
                Console.WriteLine("\t 4 - procurar ");
                Console.WriteLine("\t 5 - deletar ");
                Console.WriteLine("\t 6 - sair do sistema ");

                Console.WriteLine("Sua opção? ");
                opcaoUsuario = Convert.ToInt32(Console.ReadLine());
            }




















        }
    }
}
