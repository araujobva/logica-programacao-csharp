/*
 * Problema: Crie um array unidimencional inteiro de 20 posições, preencha ele com os valores de 1 a 20 e troque o valor 
 * da primeira posição pela última posição, depois o valor da segunda posição pela penúltima posição e assim sucessivamente. 
 * Ao final, mostre o vetor com as  posições trocadas.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaRepeticao
{
    class TrocaDeValores
    {
        public static void TrocaValores()
        {
            int[] vetor = new int[20];
            int j = 19, buffer;
            for (int i = 0; i < 20; i++) //Preenchendo o vetor.
                vetor[i] = i + 1;
            for(int i = 0; i < 10; i++)
            {
                buffer = vetor[i];
                vetor[i] = vetor[j];
                vetor[j] = buffer;
                j--;
            }
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.ReadKey();
        }
    }
}
