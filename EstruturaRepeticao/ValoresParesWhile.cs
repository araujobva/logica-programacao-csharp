//Problema: Mostre todos os valores pares positivos até 200 com a estrutura de repetição While.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaRepeticao
{
    class ValoresParesWhile
    {
        public static void MostraPares()
        {
            for (int i = 2; i <= 200; i = 2 + i)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
