using Banco.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Relatorios
{
    public class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumular(ITributavel produto)
        {
            Total += produto.CalcularTributo();
        }
    }
}
