using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
        
            try
            {
                ContaCorrente conta = new ContaCorrente(1, 2, 0);
                ContaCorrente conta2 = new ContaCorrente(12, 22, 0);

                conta2.Transferir(10000, conta);
                conta.Depositar(150);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(-500);
                Console.WriteLine(conta.Saldo);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível divisão por zero!");
            }
            catch(ArgumentException ex){
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine(ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
