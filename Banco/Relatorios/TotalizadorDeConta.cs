using Banco.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Relatorios
{
    public class TotalizadorDeConta
    {
        public double ValorTotal { get; private set; }

        public void Somar(Conta conta)
        {
            ValorTotal += conta.Saldo;
        }
    }
}
