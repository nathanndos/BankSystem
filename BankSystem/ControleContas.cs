using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class ControleContas
    {
        public List<ContaCorrente> ContasCorrentes { get; set; }

        public ControleContas()
        {
            
            ContasCorrentes = new List<ContaCorrente>();        
        }

        public void SearchAccount(int numAccount)
        {
            ContaCorrente corretAccount = ContasCorrentes.Find(i => i.NumConta == numAccount);

            if (corretAccount == null) {
                Console.Clear();
                Console.WriteLine("Error! Não foi possível encontrar esse conta");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Numero da conta: " + corretAccount.NumConta
                                                    + "\nNome: " + corretAccount.Titular.Nome +
                                                   "\nIdade: " + corretAccount.Titular.Idade +
                                                   "\nAgencia: " + corretAccount.Agencia +
                                                   "\nBanco: " + corretAccount.Banco +
                                                   "\nSaldo: R$" + corretAccount.Saldo + "\n -----------------\n");
            }    
        }
        public void RemoveAccount(int numAccount)
        {
            try
            {
                ContaCorrente corretAccount = ContasCorrentes.Find(i => i.NumConta == numAccount);

                if (corretAccount == null)
                {
                    Console.Clear();
                    Console.WriteLine("Error! Não foi possível encontrar esse conta");
                }
                else
                {
                    ContasCorrentes.Remove(corretAccount);
                    Console.WriteLine("Removido com sucesso");
                }
                
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro! Tente novamente");
            }
        }
        public void EditAccount(int numAccount)
        {
            ContaCorrente corretAccount = ContasCorrentes.Find(i => i.NumConta == numAccount);

            try
            {
                if (corretAccount == null) {
                    Console.Clear();
                    Console.WriteLine("Conta nao encontrada");
                }
                else
                {
                    
                    Console.Clear();
                    Console.WriteLine("Editando o usuario da conta "+ corretAccount.Titular.Nome+"\n");

                    Console.WriteLine("Qual informação deseja alterar?\n\n"+    
                                      "(1) Nome\n" +
                                      "(2) Idade\n" +
                                      "(3) Agencia\n" +
                                      "(4) Banco\n");

                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("## Alteração de nome##\n\n" +
                                    "Digite o novo nome: ");

                                corretAccount.Titular.Nome = Convert.ToString(Console.ReadLine());

                                Console.WriteLine("\nAlteração concluída com sucesso!");
                                Console.ReadLine();
                            }break;
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("## Alteração de idade##\n\n" +
                                    "Digite a nova idade: ");

                                corretAccount.Titular.Idade = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("\nAlteração concluída com sucesso!");
                                Console.ReadLine();
                            }
                            break;
                        case 3:
                            {
                                Console.Clear();
                                Console.WriteLine("## Alteração de Agencia ##\n\n" +
                                    "Digite o numero da nova agencia: ");

                                corretAccount.Agencia = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("\nAlteração concluída com sucesso!");
                                Console.ReadLine();
                            }
                            break;
                        case 4:
                            {
                                Console.Clear();
                                Console.WriteLine("## Alteração de Banco ##\n\n" +
                                    "Digite o nome do novo Banco: ");

                                corretAccount.Banco = Convert.ToString(Console.ReadLine());

                                Console.WriteLine("\nAlteração concluída com sucesso!");
                                Console.ReadLine();
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Digite uma informação válida");
                                Console.ReadLine();
                            }break;
                    }
                            
                }
            }
            catch
            {

            }
        }

    }
}
