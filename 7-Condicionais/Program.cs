using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos. Pode entrar");
            } else if (quantidadePessoas >= 2)
            {
                Console.WriteLine("João não possui 18 anos, mas possui 2 acompanhantes. Pode entrar");
            } else
            {
                Console.WriteLine("João não possui 18 anos, nem acompanhantes. Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
