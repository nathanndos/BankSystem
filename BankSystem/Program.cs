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

            string nomeP, bancoP;
            double saldoP;
            int idadeP, agenciaP, number, option=0;


            ControleContas controleContas = new ControleContas();

            while (another == true)
            {
                Console.WriteLine("## Mini sistema ##\n");
                Console.WriteLine("(1) Novo cadastro\n"+
                                "(2) Buscar conta\n"+
                                "(3) Editar conta\n" +
                                "(4) Excluir conta\n" +
                                "(5) Listar todos\n" +
                                "(9) Sair\n");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();  
                    Console.WriteLine("Digite uma informação valida");
                }

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

                            Console.WriteLine("\n## Ação finalizada ##");
                            Console.ReadLine();

                        }
                    break;
                    case 2:
                        {                         
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("## Busca de conta corrente");

                                Console.WriteLine("Digite o numero da conta desejada: ");
                                number = Convert.ToInt32(Console.ReadLine());

                                controleContas.SearchAccount(number);

                                Console.WriteLine("\nDeseja fazer uma nova Busca? Nao(0) Sim(1)");
                                try
                                {
                                    number = Convert.ToInt32(Console.ReadLine());
                                }
                                catch
                                {
                                    number = 0;
                                }
                                
                                if (number == 0)
                                {
                                    break;
                                }

                            } while (number == 1);


                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Qual conta deseja editar? ");
                            number = Convert.ToInt32(Console.ReadLine());

                            controleContas.EditAccount(number);
                        }break;

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Qual o numero da conta que deseja excluir? ");
                            number = Convert.ToInt32(Console.ReadLine());

                            controleContas.RemoveAccount(number);

                            Console.ReadLine();
                        }break;

                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("## Contas correntes cadastradas ##\n");
                            foreach (ContaCorrente contaCorrente in controleContas.ContasCorrentes)
                            {
                                Console.WriteLine("Numero da conta: " + contaCorrente.NumConta
                                                    + "\nNome: " + contaCorrente.Titular.Nome +
                                                   "\nIdade: " + contaCorrente.Titular.Idade +
                                                   "\nAgencia: " + contaCorrente.Agencia +
                                                   "\nBanco: " + contaCorrente.Banco +
                                                   "\nSaldo: R$" + contaCorrente.Saldo + "\n -----------------\n");
                            }
                            Console.WriteLine("\n** Fim das contas **");
                           
                            Console.ReadLine();

                        }
                        break;
                    case 9:
                        {
                            return;
                        }

                }
                Console.Clear();
            }

        }
    }
}
