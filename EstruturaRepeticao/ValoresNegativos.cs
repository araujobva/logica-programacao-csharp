//Problema: Faça um programa que que mostre os valores negativos entre 1 e 100.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaRepeticao
{
    class ValoresNegativos
    {
        public static void Mostra100ValoresNegativos()
        {
            for(int i = -1; i >= -100; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
