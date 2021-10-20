using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class ContaJuridica 
    {
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Naruto", 0.0);
            Conta2 bacc = new Conta2(1002, "Sasuke", 0.0, 500.0);

            Conta acc1 = bacc;
            Conta acc2 = new Conta2(1003, "Sakura", 0.0, 200.00);
            Conta acc3 = new ContaPoupanca(1004, "Kakashi", 0.0, 0.01);

            //condiçao
            if (acc3 is Conta2)
            {
                Conta2 acc5 = (Conta2)acc2;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }
            if (acc3 is ContaPoupanca)
            {
                ContaPoupanca acc5 = acc3 as ContaPoupanca;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
            
            Console.ReadKey();
        }
    }
}
