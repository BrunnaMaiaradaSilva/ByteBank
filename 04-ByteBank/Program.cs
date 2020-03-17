using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoVitor = new ContaCorrente();
            contaDoVitor.titular = "Vitor Waka Waka";
            contaDoVitor.saldo = 5000;

            bool resultadoSaque = contaDoVitor.Sacar(50);

            contaDoVitor.Depositar(600);

            Console.WriteLine(contaDoVitor.saldo);
            Console.WriteLine(resultadoSaque);

            ContaCorrente contaDaBrunna = new ContaCorrente();
            contaDaBrunna.titular = "Brunna Silva";
            contaDaBrunna.saldo = 10000;

            contaDaBrunna.Transferir(4000, contaDoVitor);

            Console.WriteLine(contaDoVitor.saldo);



            Console.ReadLine();
        }
    }
}
