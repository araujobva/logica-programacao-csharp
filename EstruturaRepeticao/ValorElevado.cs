//Problema: Faça um programa que receba 2 números maiores que zero e inteiros, calcule e mostre um elevado ao outro.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaRepeticao
{
    class ValorElevado
    {
        public static void CalculaValorElevado()
        {
            int valor1, valor2, resultado1, resultado2;
            Console.Write("Digite um valor inteiro e maior que zero >> ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro valor inteiro e maior que zero >> ");
            valor2 = int.Parse(Console.ReadLine());
            resultado1 = valor2;
            resultado2 = valor1;
            for (int i = 1; i < valor1; i++)
                resultado1 = resultado1 * valor2;
            for (int i = 1; i < valor2; i++)
                resultado2 = resultado2 * valor1;
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.ReadKey();
        }
    }
}
