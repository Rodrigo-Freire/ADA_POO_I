using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia_956_POO.Models
{
    public class Conta
    {
        private double saldo { get; set; }
        public string titular { get; set; }
        protected int num_conta { get; set; }

        public Conta(double saldo, string titular, int num_conta)
        {
            this.saldo = saldo;
            this.titular = titular;
            this.num_conta = num_conta;
        }
        public double Sacar(double valorSacado)
        {
            if (saldo > 0)
            {
                saldo-= valorSacado;
            }
            return saldo;
        }

        public double Transferir(double valorTransferencia)
        {
            if (num_conta > 0)
            {
                saldo-= valorTransferencia;
            }
            return saldo;
        }

        public void extrato()
        {
            Console.WriteLine($"O saldo atual é {saldo.ToString()}");
        }
    }
}
