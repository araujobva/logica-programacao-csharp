/*
 * Problema: Faça um programa que leia um valor N inteiro e positivo, calcule e mostre o valor de E, conforme a fórmula a seguir:
 * E = 1 + 1/1 + 1/2 + 1/3 + ... + 1/N.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaRepeticao
{
    class ValorDivisao
    {
        public static void Calcula()
        {
            int n, e = 1;
            Console.Write("Digite um valor inteiro e positivo >> ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                e = e + 1 / i;
            }
            Console.WriteLine("O valor de E é " + e);
            Console.ReadKey();
        }
    }
}
