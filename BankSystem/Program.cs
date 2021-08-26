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
            int number;
            int option;

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
                    Console.WriteLine("Digite uma informação válida\n");
                    option = -1;
                }

                switch (option)
                {
                    case 1:
                        {
                            bool somenteLetras = false;
                            bool validaIdade = false;
                            int idadeP = 0, agenciaP = 0;
                            string nomeP, bancoP;
                            double saldoP;

                            try
                            {
                                
                                Console.Clear();
                                Console.WriteLine(idadeP);
                                do
                                {
                                    Console.WriteLine("## Cadastro novo cliente ##\n");

                                    Console.Write("Informe o primeiro nome do cliente: ");
                                    nomeP = Convert.ToString(Console.ReadLine());
                                    for (int i = 0; i < nomeP.Length; i++)
                                    {
                                        if (char.IsLetter(nomeP[i]))
                                        {
                                            somenteLetras = true;
                                        }
                                        else
                                        {
                                            somenteLetras = false;
                                            Console.Clear();
                                            Console.WriteLine("** Nao sao permitidos números ou caracteres especiais no nome **\n");                                        
                                            break;
                                        }
                                    }
                                    if (nomeP.Length < 3 && somenteLetras == true)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("** O nome deve ter no mínimo 3 caracteres **\n");
                                    }

                                } while (somenteLetras == false || nomeP.Length < 3);

                                Console.Clear();
                                do
                                {
                                    idadeP = 0;

                                    Console.WriteLine("## Cadastro novo cliente ##\n");

                                    Console.Write("Informe a idade(somente valores númericos): ");

                                    try
                                    {
                                        idadeP = Convert.ToInt32(Console.ReadLine());
                                        if (idadeP < 16)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Não é permitido abertura de conta corrente para menores de 16 anos\n");
                                        }
                                        else if (idadeP > 120)
                                        {
                                            Console.WriteLine("O valor da idade deve estar entre o intervalo de 16 anos - 120 anos");
                                        }
                                        else { 
                                            validaIdade = true;
                                        }
                                        
                                    }
                                    catch
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Digite Apenas valores numericos\n");
                                    }

                                } while (validaIdade!=true);                         

                                Console.WriteLine("Apresenta a agencia: ");
                                agenciaP = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Qual o banco? ");
                                bancoP = Convert.ToString(Console.ReadLine());

                                Console.WriteLine("Qual o saldo inicial? ");
                                saldoP = Convert.ToDouble(Console.ReadLine());
                                /*
                                if (idadeP <0||agenciaP<0||saldoP<0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("## Cadastro não realizado ##\nUma ou mais informações estão incorretas\n");
                                }
                                else if (nomeP.Length < 3||nomeP=="")
                                {
                                    Console.Clear();
                                    Console.WriteLine("## Cadastro não realizado ##\nO Nome deve ter mais de 3 caracteres\n");
                                }
                                else
                                {
                                    controleContas.ContasCorrentes.Add(new ContaCorrente(nomeP, idadeP, agenciaP, bancoP, saldoP));
                                }*/
                                controleContas.ContasCorrentes.Add(new ContaCorrente(nomeP, idadeP, agenciaP, bancoP, saldoP));

                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Ocorreu um erro. Informe informações válidas");
                            }
                            finally
                            {
                                Console.WriteLine("\n## Ação finalizada ##");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                    break;
                    case 2:
                        {                         
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("## Busca de conta corrente ##\n");

                                Console.WriteLine("Digite o numero da conta desejada: ");
                                try
                                {
                                    number = Convert.ToInt32(Console.ReadLine());

                                    controleContas.SearchAccount(number);

                                }
                                catch
                                {
                                    Console.Clear();
                                    Console.WriteLine("** Error. Insira somente valores numéricos\n"+
                                    "Pressione Enter para continuar");
                                    Console.ReadLine();
                                    break;
                                }


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
                                    Console.Clear();
                                    break;
                                }

                            } while (number == 1);

                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Qual conta deseja editar? ");
                            try
                            {
                                number = Convert.ToInt32(Console.ReadLine());
                                controleContas.EditAccount(number);
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("** Error. Insira somente valores numéricos\n" +
                                    "Pressione Enter para continuar");
                                Console.ReadLine();
                            }
                            
                            Console.Clear();
                        }
                        break;

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Qual o numero da conta que deseja excluir? ");
                            try
                            {
                                number = Convert.ToInt32(Console.ReadLine());
                                controleContas.RemoveAccount(number);
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Ocorreu um erro. Digite somente valores numéricos\n" +
                                    "Pressione Enter para voltar ao menu principal");
                            }
                            finally
                            {
                                Console.ReadLine();
                                Console.Clear();
                            }           

                        }
                        break;

                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("## Contas correntes cadastradas ##\n");
                            if (controleContas.ContasCorrentes.Count == 0) {
                                Console.WriteLine("--- Não há contas registradas ----");
                            }
                            else
                            {
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
                            }
                            
                           
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 9:
                        {
                            return;
                        }

                }
            
            }

        }
    }
}
