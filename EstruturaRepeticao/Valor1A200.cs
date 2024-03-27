//Problema: Mostre o valor de 1 a 200.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class Valor1A100
    {
        public static void MostraValores()
        {
            for(int i = 1; i <= 200; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
