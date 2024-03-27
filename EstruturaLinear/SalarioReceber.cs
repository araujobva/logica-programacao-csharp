/*
 * Problema: Faça um programa que receba o salário-base de um funcionário, calcule e mostre o salário a receber, sabendo-se que esse funcionário 
 * tem gratificação de 5% sobre o salário-base e paga imposto de 7% sobre o salário-base. 
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class SalarioReceber
    {
        public static void Calcula()
        {
            double salarioBase, salarioFinal, gratificao = 0.05, imposto = 0.07;
            Console.Write("Digite o valor do salário base R$ ");
            salarioBase = double.Parse(Console.ReadLine());
            salarioFinal = salarioBase + (salarioBase * gratificao);
            salarioFinal = salarioFinal - (salarioBase * imposto);
            Console.WriteLine("O salário final é de R$ " + salarioFinal);
            Console.ReadKey();
        }
    }
}
