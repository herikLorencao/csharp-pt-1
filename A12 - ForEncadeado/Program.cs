using System;

namespace A12___ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12");

            double valorInvestido = 1000;
            double fatorInvestimento = 1 + 0.0036;

            for (int ano = 0; ano < 5; ano++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorInvestimento;
                }

                fatorInvestimento += 0.0010;
            }

            Console.WriteLine("O valor total ao final do investimento será de R$ " + valorInvestido);
            Console.ReadLine();
        }
    }
}
