//Problema: Faça um programa que receba quatro números inteiros, calcule e mostre a soma desses números.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class Soma4Valores
    {
        public static void Soma()
        {
            int v1, v2, v3, v4, soma;
            Console.Write("Digite o primeiro valor >> ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor >> ");
            v2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor >> ");
            v3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o quarto valor >> ");
            v4 = int.Parse(Console.ReadLine());
            soma = v1 + v2 + v3 + v4;
            Console.WriteLine("A soma dos 4 valores inseridos é de >> " + soma);
            Console.ReadKey();
        }
    }
}
