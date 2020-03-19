using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Brunna Silva";
            cliente.CPF = "445.678.987.56";
            cliente.Profissao = "Desenvolvedora C#";

            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();

        }
    }
}
