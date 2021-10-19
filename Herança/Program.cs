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
            Conta2 ContaJu;

            ContaJu = new Conta2(8010,"Lara", 100.0, 500.0);
            Console.WriteLine(value: ContaJu.Saldo);

            Console.ReadKey();
        }
    }
}
