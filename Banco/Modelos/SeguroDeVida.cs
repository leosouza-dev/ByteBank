using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Modelos
{
    public class SeguroDeVida : ITributavel
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public double CalcularTributo()
        {
            return 50;
        }
    }
}
