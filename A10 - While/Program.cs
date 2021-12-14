using System;

namespace A10___While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Valor para o mês " + contadorMes + " é igual a R$ " + valorInvestido);
                contadorMes++;
            }

            Console.ReadLine();
        }
    }
}
