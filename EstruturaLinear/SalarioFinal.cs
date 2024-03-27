/* 
 * Problema: Faça um programa que receba o número de horas trabalhadas e o valor do salário-mínimo. Calcule e mostre o salário a receber seguindo as regras abaixo:
 * a) A hora trabalhada vale a metade do salário-mínimo.
 * b) O salário bruto equivale ao número de horas trabalhadas multiplicado pelo valor da hora trabalhada.
 * c) O imposto equivale a 3% do salário bruto.
 * d) O salário a receber equivale ao salário bruto menos o imposto.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class SalarioFinal
    {
        public static void CalculaSalarioFinal()
        {
            double salarioMinimo, salarioFinal, valorHoraTrabalhada;
            int horasTrabalhadas;
            Console.Write("Digite o valor do salário mínimo R$ ");
            salarioMinimo = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de horas trabalhadas >> ");
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorHoraTrabalhada = salarioMinimo / 2;
            salarioFinal = valorHoraTrabalhada * horasTrabalhadas;
            salarioFinal = salarioFinal - (salarioFinal * 0.03);
            Console.WriteLine("O salário final é de R$ " + salarioFinal);
            Console.ReadKey();
        }
    }
}
