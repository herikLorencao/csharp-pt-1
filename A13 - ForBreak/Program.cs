using System;

namespace A13___ForBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write('*');
                    if (j >= i)
                        break;
                }
                Console.WriteLine();
            }

            // Forma sem break

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
