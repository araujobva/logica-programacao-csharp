//Problema: Faça um programa que receba três números obrigatoriamente inteiros e em ordem crescente e um quarto número que não siga esta regra. Mostre, em seguida, os quatro números em ordem crescente.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class Colocando4ValoresOrdemCrescente
    {
        public static void Ordena()
        {
            int v1, v2, v3, v4;
            Console.Write("Digite o primeiro valor inteiro >> ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um segundo valor inteiro maior que o primeiro >> ");
            v2 = int.Parse(Console.ReadLine());
            Console.Write("Digite um terceiro valor inteiro maior que o segundo >> ");
            v3 = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor inteiro >> ");
            v4 = int.Parse(Console.ReadLine());
            if (v4 < v1)
                Console.WriteLine("Os números em ordem crescente são {0} {1} {2} {3}", v4, v1, v2, v3);
            else if(v4 < v2 && v4 > v1)
                Console.WriteLine("Os números em ordem crescente são {0} {1} {2} {3}", v1, v4, v2, v3);
            else if(v4 < v3 && v4 > v2)
                Console.WriteLine("Os números em ordem crescente são {0} {1} {2} {3}", v1, v2, v4, v3);
            else if(v4 > v3)
                Console.WriteLine("Os números em ordem crescente são {0} {1} {2} {3}", v1, v2, v3, v4);
            Console.ReadKey();
        }
    }
}
