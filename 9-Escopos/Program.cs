﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9");

            int idadeJoao = 16;
            int quantidadePessoas = 2;
            string mensagemAdicional;

            bool acompanhado = quantidadePessoas >= 2;

            if (acompanhado)
                mensagemAdicional = "João está acompanhado";
            else
                mensagemAdicional = "João NÃO está acompanhado";


            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
                Console.WriteLine(mensagemAdicional);
            }

            Console.ReadLine();
        }
    }
}
