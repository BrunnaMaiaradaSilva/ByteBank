using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
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

            ContaCorrente contaDaBrunnaSilva = new ContaCorrente();
            contaDaBrunnaSilva.titular = "Brunna Silva";
            contaDaBrunnaSilva.agencia = 99765;
            contaDaBrunnaSilva.numero = 549134;
            contaDaBrunnaSilva.saldo = 4890.85;

            Console.WriteLine(contaDaBrunna == contaDaBrunnaSilva);

            Console.ReadLine();
        }
    }
}
