using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Modelos
{
    public class ContaInvestimento : Conta, ITributavel
    {
        public ContaInvestimento(string titular) : base(titular)
        {
        }

        public double CalcularTributo()
        {
            return Saldo * 0.02;
        }
    }
}
