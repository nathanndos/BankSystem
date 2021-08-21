using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Cliente
    {
        public string Nome { get; set; }
        private int _idade;
        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value < 18) {
                    return;
                }
                _idade = value;
            }
        }
     
    }
}
