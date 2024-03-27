/*
 * Problema: Sabe-se que o quilowatt de energia custa um quinto do salário-mínimo. Faça um programa que receba o valor do salário-mínimo e a quantidade de quilowatts consumida por uma residência. 
 * Calcule e mostre:
 * a) O valor, em reais, de cada quilowatt.
 * b) O valor, em reais, a ser pago por essa residência.
 * c) O valor, em reais, a ser pago com desconto de 15%.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class CalculoQuilowatt
    {
        public static void CalculandoQuilowatts()
        {
            double salMinimo, quantQwatt, valorCadaQwatt, valorPagoResidencia, valorDesc;
            Console.Write("Digite o valor do salário mínimo R$ ");
            salMinimo = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de quilowatts consumida por essa residência >> ");
            quantQwatt = double.Parse(Console.ReadLine());
            valorCadaQwatt = salMinimo / 5;
            valorPagoResidencia = valorCadaQwatt * quantQwatt;
            valorDesc = valorPagoResidencia - (valorPagoResidencia * 0.15);
            Console.WriteLine("O valor de cada quilowatt é de R$ "+valorCadaQwatt);
            Console.WriteLine("O valor em reais a ser pago pela reidência é de R$ "+ valorPagoResidencia);
            Console.WriteLine("O valor a ser pago com desconto de 15% é de R$ " + valorDesc);
            Console.ReadKey();
        }
    }
}
