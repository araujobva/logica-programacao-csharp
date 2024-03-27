//Problema: Faça um programa que monte os trinta primeiros termos da sequência de Fibonacci.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaRepeticao
{
    class Fibonacci
    {
        public static void CalculaFibonacci()
        {
            int[] fibonacci = new int[30];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 1; i <= 28; i++)
            {
                fibonacci[i + 1] = fibonacci[i] + fibonacci[i - 1];
            }
            Console.WriteLine("Os 30 valores fibonaccis são:\n");
            for (int i = 0; i < 30; i++)
            {
                Console.Write("{0} - ", fibonacci[i]);
            }
            Console.ReadKey();
        }
    }
}
