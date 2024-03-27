//Problema: Mostre todos os valores pares positivos até 200 com a estrutura de repetição DO-While.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaRepeticao
{
    class ValoresParesDoWhile
    {
        public static void Mostra200Valores()
        {
            int i = 2;
            do
            {
                Console.WriteLine(i);
                i = i + 2;
            } while (i <= 200);
            Console.ReadKey();
        }
    }
}
