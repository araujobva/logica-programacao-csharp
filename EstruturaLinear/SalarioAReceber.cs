/* 
 * Problema: Faça um programa que receba o número de horas trabalhadas, o valor do salário-mínimo e o número de horas extras trabalhadas. Calcule e mostre o salário a receber seguindo as regras a seguir.
 * a) A hora trabalhada vale 1/8 do salário-mínimo.
 * b) A hora extra vale 1/4 do salário-mínimo.
 * c) O salário bruto equivale ao número de horas trabalhadas multiplicado pelo valor da hora trabalhada.
 * d) A quantia a receber pelas horas extras equivale ao número de horas extras tralhadas multiplicado pelo valor da hora extra.
 * e) O salário a receber equivale ao salário bruto mais a quantia a receber pelas horas extras.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class SalarioAReceber
    {
        public static void CalculaSalario()
        {
            int nHorasTrabalhadas, nHorasExtrasTrabalhadas;
            double valorHoraTrabalhada, valorHoraExtraTrabalhada, salarioBruto, salarioMinimo;
            Console.Write("Digite o número de horas trabalhadas >> ");
            nHorasTrabalhadas = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de hroas extras trabalhadas >> ");
            nHorasExtrasTrabalhadas = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do salário mínimo R$ ");
            salarioMinimo = double.Parse(Console.ReadLine());
            valorHoraTrabalhada = salarioMinimo / 8;
            valorHoraExtraTrabalhada = salarioMinimo / 4;
            salarioBruto = (valorHoraExtraTrabalhada * nHorasExtrasTrabalhadas) + (valorHoraTrabalhada * nHorasTrabalhadas);
            Console.WriteLine("O salário bruto a receber é de R$ " + salarioBruto);
            Console.ReadKey();
        }
    }
}
