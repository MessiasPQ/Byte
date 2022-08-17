using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
             /*
            ContaCorrente conta2 = new ContaCorrente(1022, 12345678, 1300.79);
            Cliente titular = new Cliente();
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(ContaCorrente.TaxaOperacao);
            */
            try
            {
                ContaCorrente conta = new ContaCorrente(5, 1, 0);
                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível divisão por zero!");
            }
            catch(ArgumentException e){
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                 Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Aconteceu um erro!");
            }
            //Metodo();
        }
        private static void Metodo()
        {
           TestaDivisao(0);
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
