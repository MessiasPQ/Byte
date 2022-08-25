using System;
// using ByteBank;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; } 
        public Cliente Titular { get; set; }
        public int Numero { get; }
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia{ get; }

        private double _saldo = 200;
        public double Saldo
        {

            get
            {
                return this._saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                this._saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero, double saldo)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("A agência deve ser maiores que zero.", nameof(agencia));
            }
            if(numero <= 0)
            {
                throw new ArgumentException("O número deve ser maior que zero.", nameof(numero));
            }
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }
        public void Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para o saque no valor de " + valor);
            }
            this._saldo -= valor;
           
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }
}

