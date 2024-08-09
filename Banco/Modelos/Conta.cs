using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Modelos
{
    public abstract class Conta
    {
        private static int totalDeContas;
        protected Conta(string titular)
        {
            Conta.totalDeContas++;
            this.Numero = totalDeContas;
            Titular = titular;
        }

        public string Titular { get; protected set; }
        public int Numero { get; protected set; }
        public double Saldo { get; protected set; }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
            }        
        }

        public void Transferir(double valor, Conta contaDestino)
        {
            if(Saldo >= valor)
            {
                this.Sacar(valor);
                contaDestino.Depositar(valor);
            }
        }
    }
}
