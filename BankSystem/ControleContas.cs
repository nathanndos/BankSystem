using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class ControleContas
    {
        public IList<ContaCorrente> ContasCorrentes { get; set; }

        public ControleContas()
        {
            ContasCorrentes = new List<ContaCorrente>();        
        }
    }
}
