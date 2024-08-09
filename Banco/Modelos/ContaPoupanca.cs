using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Modelos
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string titular) : base(titular)
        {
        }

        public override void Sacar(double valor)
        {
            base.Sacar(valor +  0.10);
        }
    }
}
