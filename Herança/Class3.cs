using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class ContaPoupanca : Conta
    {
        //Declarações das variáveis e uso do encapsulamento
        public double TaxaJuros { get; set; }
        //Construtor padrão
        public ContaPoupanca() { }
        //Construtor com parâmetros
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }
        public void atualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
    }
}
