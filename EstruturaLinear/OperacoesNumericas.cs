/* 
 * Problema: Faça um programa que receba um número positivo e maior que zero, calcule e mostre:
 * a) O número digitado ao quadrado.
 * b) O número digitado ao cubo.
 * c) A raiz quadrada do número digitado.
 * d) A raiz cúbica do número digitado.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class OperacoesNumericas
    {
        public static void Calcula()
        {
            int valor;
            double quadrado, cubo, raizQuadrada, raizCubica;
            Console.Write("Digite um valor inteiro e positivo >> ");
            valor = int.Parse(Console.ReadLine());
            quadrado = Math.Pow(valor, 2);
            cubo = Math.Pow(valor, 3);
            raizQuadrada = Math.Sqrt(valor);
            raizCubica = Math.Pow(valor, 1.0 / 3.0);
            Console.WriteLine("O valor {0} ao quadrado é >> {1}", valor, quadrado);
            Console.WriteLine("O valor {0} ao cubo é >> {1}", valor, cubo);
            Console.WriteLine("A raiz quadrada do valor {0} é >> {1}", valor, raizQuadrada);
            Console.WriteLine("A raiz cúbica do valor {0} é >> {1}", valor, raizCubica);
            Console.ReadKey();
        }
    }
}
