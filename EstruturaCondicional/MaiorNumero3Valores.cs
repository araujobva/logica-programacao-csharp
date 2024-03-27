//Problema: Crie um programa que receba três números e mostre o maior.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class MaiorNumero3Valores
    {
        public static void MostraMaior()
        {
            double valor1, valor2, valor3;
            Console.Write("Digite o primeiro valor >> ");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segunda valor >> ");
            valor2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor >> ");
            valor3 = double.Parse(Console.ReadLine());
            if (valor1 > valor2 && valor1 > valor3)
                Console.Write("O {0} é o maior valor.", valor1);
            else if (valor2 > valor1 && valor2 > valor3)
                Console.Write("O {0} é o maior valor.", valor2);
            else if (valor3 > valor1 && valor3 > valor2)
                Console.Write("O {0} é o maior valor.", valor3);
            Console.ReadKey();
        }
    }
}
