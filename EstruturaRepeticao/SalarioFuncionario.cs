/*
 * Problema: Um funcionário de uma empresa recebe aumento salarial anualemente. Sabe-se que:
 * a. Esse funcionário foi contratado em 1995, com salário inicial de R$ 1.000,00.
 * b. Em 1996 recebeu aumento de 1,5% sobre seu salário inicial.
 * c. A partir de 1997 (inclusive), os aumentos salariais sempre corresponderam ao dobro do percentual do ano anterior.
 * Faça um programa que determine o salário atual desse funcionário. 
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaRepeticao
{
    class SalarioFuncionario
    {
        public static void CalculaSalario()
        {
            double salario, perc = 0.015, salarioFinal = 1000, anoAtual;
            Console.Write("Digite o ano atual >> ");
            anoAtual = double.Parse(Console.ReadLine());
            for(int i = 1996; i <= anoAtual; i++)
            {
                salarioFinal = salarioFinal + (salarioFinal * perc);
                perc = perc * 2;
            }
            Console.WriteLine("O salário final é de R$ " + salarioFinal);
            Console.ReadKey();
        }
    }
}
