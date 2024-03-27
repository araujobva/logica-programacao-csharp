/*
 * Problema: Faça um programa que receba a altura e o peso de uma pessoa. De acordo com as informações abaixo, verifique e mostre qual a classificação dessa pessoa.
 * - Altura menor que 1,20: Peso até 60 classificação A, entre 60 e 90 (inclusive) classificação D e acima de 90 classificação G.
 * - Altura de 1,20 a 1,70: Peso até 60 classificação A, entre 60 e 90 (inclusive) classificação E e acima de 90 classificação H.
 * - Altura maior que 1,70: Peso até 60 classificação C, entre 60 e 90 (inclusive) classificação F e acima de 90 classificação I.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class PesoClassificacao
    {
        public static void CalculaClassificacao()
        {
            double altura, peso;
            char cl = 'W';
            Console.Write("Digite a sua altura >> ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu peso >> ");
            peso = double.Parse(Console.ReadLine());
            if (altura < 1.20)
            {
                if (peso <= 60)
                    cl = 'A';
                else if (peso >= 60 && peso <= 90)
                    cl = 'D';
                else if (peso > 90)
                    cl = 'G';
            }else if(altura >= 1.20 && altura <= 1.70)
            {
                if (peso <= 60)
                    cl = 'A';
                else if (peso >= 60 && peso <= 90)
                    cl = 'E';
                else if (peso > 90)
                    cl = 'H';
            }else if(altura > 1.70)
            {
                if (peso <= 60)
                    cl = 'C';
                else if (peso >= 60 && peso <= 90)
                    cl = 'F';
                else if (peso > 90)
                    cl = 'I';
            }
            Console.WriteLine("A classificação desta pessoa é "+cl);
            Console.ReadKey();
        }
    }
}
