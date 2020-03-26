using System;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        //Propriedades da classe Conta Corrente
        public Cliente Titular { get; set; }

        public static double TaxaDeOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

       
        public int Agencia{ get; }

        public int Numero { get; }


        private double _saldo;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        //Construtor da classe conta corrente
        public ContaCorrente(int agencia, int numero)
        {
            //Exceções
            if(agencia <= 0 )
            {                
                ArgumentException excecao = new ArgumentException("A agência deve ser maior que 0.", nameof(agencia));
                
                throw excecao;
            }

            if (numero <= 0)
            {
                ArgumentException excecao = new ArgumentException("O número da conta deve ser maior que 0.", nameof(numero));

                throw excecao;
            }

            //Propriedades do construtor da classe conta corrente
            Agencia = agencia;
            Numero = numero;

            //métodos da classe conta corrente
            TaxaDeOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }

        //Funções da classe conta corrente
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;

            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDeDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            contaDeDestino.Depositar(valor);

            return true;
        }
    }
}