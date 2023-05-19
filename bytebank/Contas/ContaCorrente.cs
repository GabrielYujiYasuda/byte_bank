﻿using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public double saldo;
        public Cliente titular;

        public ContaCorrente() { } //Empty constructor

        public ContaCorrente(int numero_agencia, string conta, Cliente titular, double saldo)
        {
            this.numero_agencia = numero_agencia;
            this.conta = conta;
            this.titular = titular;
            this.saldo = saldo;
        }

        public void Depositar(double deposito)
        {
            //both work
            //this.saldo += deposito;
            saldo += deposito;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }

            return false;
        }

        public void Transferir(ContaCorrente ccRecebe, double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                ccRecebe.saldo += valor;
            }
        }
    }
}