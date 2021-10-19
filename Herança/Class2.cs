using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Conta2 : Conta
    {
        //Declarações das variáveis e uso do encapsulamento
        public double EmprestimoLimite { get; set; }
        //Cconstrutor padrão
        public Conta2() { }
        //Construtor com parâmetros utilizando o da Classe Conta
        public Conta2(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }
        public void Emprestimo(double saldoTotal)
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }
    }
}
