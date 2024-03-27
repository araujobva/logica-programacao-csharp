//Problema: Mostre todos os valores pares positivos até 200 com a estrutura de repetição For.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaRepeticao
{
    class ValoresParesFor
    {
        public static void MostraValorFor()
        {
            for(int i = 2; i <= 200; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
