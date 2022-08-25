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
                ContaCorrente conta = new ContaCorrente(1, 2, 0);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível divisão por zero!");
            }
            catch(ArgumentException ex){
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo Saldo Insuficiente Exception");
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
