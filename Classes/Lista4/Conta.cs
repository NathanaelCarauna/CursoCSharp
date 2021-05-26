using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Lista4
{
    class Conta
    {
        public string Titular { get; set; }
        public string NumeroDaConta { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string titular, string numeroDaConta)
        {
            Titular = titular;
            NumeroDaConta = numeroDaConta;
        }

        public Conta(string titular, string numeroDaConta, double saldo)
        {
            Titular = titular;
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
                Saldo += valor;
            else
                return;
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor + 5;
            }                
        }

        public override string ToString()
        {
            return $"Conta: {NumeroDaConta}, Titular: {Titular}, Saldo: R$ {Saldo:F2}";
        }
    }
}
