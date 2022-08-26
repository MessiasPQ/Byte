using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
        
            try
            {
                ContaCorrente conta1 = new ContaCorrente(1123, 2, 150);
                ContaCorrente conta2 = new ContaCorrente(12, 22, 50);

                conta1.Transferir(10000, conta2);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            //Metodo();
        }
        private static void Metodo()
        {
           TestaDivisao(2);
        }
        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }
        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com número =" + numero + " e divisor =" + divisor);
                throw;
            }
        }
    }
}
