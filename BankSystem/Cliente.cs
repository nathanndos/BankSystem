using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Cliente
    {
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length<3||value=="") {
                    _nome = "Conta inválida";
                }
                else
                {
                    _nome = value;
                }
            }
        }


        private int _idade;
        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value < 16) {
                    return;
                }
                _idade = value;
            }
        }
     
    }
}
