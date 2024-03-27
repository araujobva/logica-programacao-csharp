//Problema: Faça um programa que determine e mostre os cinco primeiros múltiplos de 3, considerando números > 0.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaRepeticao
{
    class Multiplos3
    {
        public static void MostraMultiplos3()
        {
            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i * 3 + "");
            }
            Console.ReadKey();
        }
    }
}
