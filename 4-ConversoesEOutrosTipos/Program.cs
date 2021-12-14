using System;

namespace _4_ConversoesEOutrosTipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario = 1200.50;
            // int possui 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            // long possui 64 bits
            long idade = 130000000000000;
            Console.WriteLine(idade);

            // o short possui 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            // pouco utilizado por padrão suporta 32 bits
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
