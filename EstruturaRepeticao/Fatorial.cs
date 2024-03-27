/*
 * Problema: Faça um programa que leia um número N inteiro, e faça o fatorial deste número.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaRepeticao
{
    class Fatorial
    {
        public static void CalculaFatorial()
        {
            int valor, fatorial = 0, x;
            Console.Write("Digite um valor positivo e inteiro para calcularmos o fatorial >> ");
            valor = int.Parse( Console.ReadLine());
            for(int i = 1; i < valor; i++)
            {
                x = valor * i;
                fatorial = fatorial + x;
            }
            Console.WriteLine("O fatorial de {0} é {1}",valor,fatorial);
            Console.ReadKey();
        }
    }
}
