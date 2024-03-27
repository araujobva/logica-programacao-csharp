//Problema: Faça um programa que calcule e mostre a tabuada de um número digitado pelo usuário.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaRepeticao
{
    class Tabuada
    {
        public static void CalculaTabuada()
        {
            int valor;
            Console.Write("Digtie um valor para calcular sua tabuada >> ");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Tabuada de " + valor);
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",i,valor,(valor * i));
            }
            Console.ReadKey();
        }
    }
}
