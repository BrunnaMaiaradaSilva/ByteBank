using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           ContaCorrente contaDaBrunna = new ContaCorrente();
            contaDaBrunna.titular = "Brunna Silva";
            contaDaBrunna.agencia = 99765;
            contaDaBrunna.numero = 549134;
            contaDaBrunna.saldo = 4890.85;

            Console.WriteLine(contaDaBrunna.titular);
            Console.WriteLine(contaDaBrunna.agencia);
            Console.WriteLine(contaDaBrunna.numero);
            Console.WriteLine(contaDaBrunna.saldo);

            contaDaBrunna.saldo += 5000;

            Console.ReadLine();
        }
    }
}
