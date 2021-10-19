using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Conta
    {
        //Declarações das variáveis e uso do encapsulamento
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        //Uso do protected para alterar de valores entre as classes
        public double Saldo { get; protected set; }
        //Construtor padrão e construtor com parâmetros
        public Conta() { }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero; 
            Titular = titular; 
            Saldo = saldo;
        }
        //Método de Saque
        public void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }
        //Método de Deposito
        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}
