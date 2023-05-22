using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }
            private set 
            {
                if (value > 0)
                {
                    this.numeroAgencia = value;
                }
            }
        }
        public string Conta { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }
        public static int TotalContasCriadas { get; set; }

        public ContaCorrente()
        {
            TotalContasCriadas++;
        }

        public ContaCorrente(int numero_agencia, string conta)
        {
            NumeroAgencia = numero_agencia;
            Conta = conta;
            TotalContasCriadas++;
        }

        public void Depositar(double deposito)
        {
            //both work
            //this.saldo += deposito;
            Saldo += deposito;
        }

        public bool Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }

            return false;
        }

        public void Transferir(ContaCorrente ccRecebe, double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                ccRecebe.Saldo += valor;
            }
        }

        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }

            Saldo = valor;
        }
    }
}
