using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11___For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= (1 + 0.0036);
                Console.WriteLine("Valor para o mês " + contadorMes + " é igual a R$ " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
