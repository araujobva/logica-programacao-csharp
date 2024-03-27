//Problema: Faça um programa que receba dois número e mostre o maior.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class MaiorNumero
    {
        public static void CalculaMaiorNumero()
        {
            double v1, v2;
            Console.Write("Digite o primeiro valor >> ");
            v1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor >> ");
            v2 = double.Parse(Console.ReadLine());
            if (v1 > v2)
                Console.WriteLine("O valor primeiro valor, {0}, é o maior.", v1);
            else
                Console.WriteLine("O valor segundo valor, {0}, é o maior.", v2);
            Console.ReadKey();
        }
    }
}
