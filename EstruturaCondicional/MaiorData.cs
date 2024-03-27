/*
 * Problema: Faça um programa que determine a data cronologicamente maior de duas datas fornecidas pelo usuário. 
 * Cada data deve ser fornecida por três valores inteiros, onde o primeiro representa o dia, o segundo o mês e o terceiro o ano. 
 * Calcule e mostre qual pessoa é mais velha ou se elas nasceram no mesmo dia, mês e ano.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class MaiorData
    {
        public static void Calcula()
        {
            int dia1, mes1, ano1, dia2, mes2, ano2;
            Console.Write("Digite o dia de nascimento da primeira pessoa >> ");
            dia1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o mês de nascimento da primeira pessoa >> ");
            mes1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano de nacimento da primeira pessoa >> ");
            ano1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o dia de nascimento da segunda pessoa >> ");
            dia2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o mês de nascimento da segunda pessoa >> ");
            mes2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano de nacimento da segunda pessoa >> ");
            ano2 = int.Parse(Console.ReadLine());
            if (ano1 > ano2)
                Console.WriteLine("A segunda pessoa é mais velha.");
            else if (ano2 > ano1)
                Console.WriteLine("A primeira pessoa é mais velha.");
            else if (mes1 > mes2)
                Console.WriteLine("A segunda pessoa é mais velha.");
            else if (mes2 > mes1)
                Console.WriteLine("A primeira pessoa é mais velha.");
            else if (dia1 > dia2)
                Console.WriteLine("A segunda pessoa é mais velha.");
            else if (dia2 > dia1)
                Console.WriteLine("A primeira pessoa é mais velha.");
            else
                Console.WriteLine("As duas pessoas nasceram no mesmo dia, mês e ano.");
            Console.ReadKey();
        }
    }
}
