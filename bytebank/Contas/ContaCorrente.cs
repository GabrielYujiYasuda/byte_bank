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
        private int numeroAgencia;  //{ get; set; }
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }
            set 
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

        public ContaCorrente() { } //Empty constructor

        public ContaCorrente(int numero_agencia, string conta, Cliente titular, double saldo)
        {
            NumeroAgencia = numero_agencia;
            this.Conta = conta;
            this.Titular = titular;
            this.Saldo = saldo;
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

            this.Saldo = valor;
        }
    }
}
