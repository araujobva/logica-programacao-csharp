//Problema: Faça um programa que receba três número e mostre-os em ordem crescente.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class ValoresOrdemCrescente
    {
        public static void OrdemCrescente()
        {
            double valor1, valor2, valor3;
            Console.Write("Digite o primeiro valor >> ");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor >> ");
            valor2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor >> ");
            valor3 = double.Parse(Console.ReadLine());
            if(valor1 > valor2 && valor2 > valor3)
            {
                Console.WriteLine("Valores em ordem crescente >> {0} - {1} - {2}" , valor3 , valor2 , valor1);
            }else if(valor1 > valor3 && valor3 > valor2)
            {
                Console.WriteLine("Valores em ordem crescente >> {0} - {1} - {2}" , valor2 , valor3 , valor1);
            }else if(valor2 > valor1 && valor1 > valor3)
            {
                Console.WriteLine("Valores em ordem crescente >> {0} - {1} - {2}" , valor3 , valor1 , valor2);
            }else if(valor2 > valor3 && valor3 > valor1)
            {
                Console.WriteLine("Valores em ordem crescente >> {0} - {1} - {2}" , valor1 , valor3 , valor2);
            }else if(valor3 > valor1 && valor1 > valor2)
            {
                Console.WriteLine("Valores em ordem crescente >> {0} - {1} - {2}" , valor2 , valor1 , valor3);
            }else if(valor3 > valor2 && valor2 > valor1)
            {
                Console.WriteLine("Valores em ordem crescente >> {0} - {1} - {2}" , valor1 , valor2 , valor3);
            }
            Console.ReadKey();
        }
    }
}
