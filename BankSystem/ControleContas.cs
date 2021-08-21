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
    }
}
