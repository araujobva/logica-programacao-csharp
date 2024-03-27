/*
 * Problema: Faça um programa que receba o valor do salário mínimo, o número de horas trabalhadas, o númeo de dependentes do funcionário e a quantidade de horas extras trabalhdas. 
 * Calcule e mostre o salário líquido a receber do funcionário de acordo com as regras a seguir:
 * 
 * - O valor da hora trabalhada é igual a 1/5 do salário mínimo.
 * - O salário do mês é igual ao número de horas trabalhadas multiplicado pelo valor da hora trabalhada.
 * - Para cada dependente acrescentar R$ 32,00.
 * - Para cada hora extra trabalhada, calcular o valor da hora trabalhada acrescida de 50% em cima da hora trabalhada.
 * - O salário bruto é igual ao salário do mês, mais o valor dos dependentes, mais o valor das horas extras.
 * 
 * Calcular o valor do imposto de renda retido na fonte de acordo com as informações abaixo.
 * - Se o salário bruto for inferior a R$ 200,00 o IR será isento.
 * - Se o salário bruto for de R$ 200,00 até R$ 500,00 o IR será de 10%.
 * - Se o salário bruto for superior a R$ 500,00 o IR será de 20%.
 * 
 * - O salário líquido é igual ao salário bruto menos IR.
 * 
 * A gratificação seguirá as regras abaixo:
 * - Se o salário líquido for até R$ 350,00 a gratificação será de R$ 100,00
 * - Se o salário líquido for superior a R$ 350,00 a gratificação será de R$ 50,00
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class SalarioVariasCondicoes
    {
        public static void CalculaSalarioVariasCondicoes()
        {
            double salarioMinimo, valorHoraTrabalhada, salarioMensal;
            int depedentes, horasTrabalhadas, horasExtrasTrabalhadas;
            Console.Write("Digite o valor do salario minimo R$ ");
            salarioMinimo = double.Parse(Console.ReadLine());
            Console.Write("Digite o numero de horas trabalhadas >> ");
            horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de horas extras trabalhadas >> ");
            horasExtrasTrabalhadas = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de depedentes do funcionario >> ");
            depedentes = int.Parse(Console.ReadLine());
            valorHoraTrabalhada = salarioMinimo / 5; //Calculando o valor da hora extra.
            salarioMensal = valorHoraTrabalhada * horasTrabalhadas; //Calculando o valor do salário.
            salarioMensal = salarioMensal + (32 * depedentes); //Calculando o acrescimo do valor relacionado aos depedentes.
            salarioMensal = salarioMensal + (horasExtrasTrabalhadas * (horasTrabalhadas + horasTrabalhadas * 0.5)); //Calculando o valor das horas extras trabalhadas.
            if (salarioMensal >= 200 && salarioMensal <= 500)
            { //Calcula o IR.
                salarioMensal = salarioMensal - (salarioMensal * 0.1);
            }
            else if (salarioMensal > 500)
            {
                salarioMensal = salarioMensal - (salarioMensal * 0.2);
            }
            if (salarioMensal <= 350)
            { //Calcula a bonificação e gratificação.
                salarioMensal = salarioMensal + 100;
                Console.WriteLine("O salario a receber e de R$ " + salarioMensal);
            }
            else if (salarioMensal > 350)//Calcula a gratificação.
            {
                salarioMensal = salarioMensal + 50;
                Console.WriteLine("O salario a receber e de R$ " + salarioMensal);
            }
            Console.ReadKey();
        }
    }
}
