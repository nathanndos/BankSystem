using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class ContaCorrente
    {
        private static int Id { get;set; }

        public int NumConta { get; private set; }

        private Cliente _titular;
        public Cliente Titular
        {
            get { return _titular; }
            set
            {
                _titular = value;
            }
        }

        public int Agencia { get; set; }
        public string Banco { get; set; }
        private double _saldo = 0;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(string nome, int idade, int agencia, string banco, double saldo )
        {
            Id++;
            Titular = new Cliente();
            Titular.Nome = nome;
            Titular.Idade = idade;
            Agencia = agencia;
            Banco = banco;
            Saldo = saldo;
            NumConta = Id;
            
            
        }
    }
}
