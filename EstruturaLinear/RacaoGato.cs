/*
 * Problema: Pedro comprou um saco de ração com peso em quilos. Pedro possui dois gatos para os quais fornece a quantidade de 
 * ração em gramas. Faça um programa que receba o peso do saco de ração e a quantidade de ração fornecida para cada gato. 
 * Calcule e mostre quanto restará de ração no saco após cinco dias.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class RacaoGato
    {
        public static void Calcula()
        {
            double pesoSacoQuilos, pesoSacoGramas, gato1, gato2;
            Console.Write("Digite o peso em quilos do saco de ração >> ");
            pesoSacoQuilos = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade em gramas fornecida diariamente para o gato 1 >> ");
            gato1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade em gramas fornecida diariamente para o gato 2 >> ");
            gato2 = double.Parse(Console.ReadLine());
            pesoSacoGramas = pesoSacoQuilos * 1000;
            pesoSacoGramas = pesoSacoGramas - ((gato1 + gato2) * 5);
            Console.WriteLine("Restará {0} gramas do saco após 5 dias.", pesoSacoGramas);
            Console.ReadKey();
        }
    }
}
