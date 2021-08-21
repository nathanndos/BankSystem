using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool another = true;
            int option ;

            string nomeP, bancoP;
            double saldoP;
            int idadeP, agenciaP;

            ControleContas controleContas = new ControleContas();

            while (another == true)
            {
                Console.WriteLine("## Mini sistema ##\n");
                Console.WriteLine("(1) Novo cadastro\n"+
                                "(2) Buscar conta\n"+
                                "(3) Editar tttconta\n" +
                                "(4) Excluir conta\n" +
                                "(5) Listar todos\n" +
                                "(9) Sair\n");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("## Cadastro novo cliente ##");
                            Console.WriteLine("Informe o nome do cliente: ");
                            nomeP = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Informe a idade: ");
                            idadeP = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Apresenta a agencia: ");
                            agenciaP = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Qual o banco? ");
                            bancoP = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Qual o saldo inicial? ");
                            saldoP = Convert.ToDouble(Console.ReadLine());


                           controleContas.ContasCorrentes.Add(new ContaCorrente(nomeP, idadeP, agenciaP, bancoP, saldoP));

                        }
                    break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("## Contas correntes cadastradas ##\n");
                            foreach (ContaCorrente contaCorrente in controleContas.ContasCorrentes)
                            {
                                Console.WriteLine("Id: " + contaCorrente.NumConta
                                                    +"\nNome: " + contaCorrente.Titular.Nome+
                                                   "\nIdade: " + contaCorrente.Titular.Idade+
                                                   "\nAgencia: " + contaCorrente.Agencia+
                                                   "\nBanco: "+ contaCorrente.Banco +
                                                   "\nSaldo: R$"+ contaCorrente.Saldo+"\n -----------------\n");
                            }
                            Console.WriteLine("\n** Fim das contas **");
                            Console.ReadLine();

                        }
                        break;
                }
                Console.Clear();
                Console.WriteLine("\n## Ação finalizada ##\n");          

            }

        }
    }
}
