//Problema: Faça um programa que receba um valor inteiro, mostre se esse valor é par ou ímpar.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class ParOuImpar
    {
        public static void Mostra()
        {
            int valor;
            Console.Write("Digite um valor inteiro >> ");
            valor = int.Parse(Console.ReadLine());
            valor = valor % 2;
            if (valor == 0)
                Console.WriteLine("O valor digitado é par.");
            else
                Console.WriteLine("O valor digitado é ímpar.");
            Console.ReadKey();
        }
    }
}
