﻿namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
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