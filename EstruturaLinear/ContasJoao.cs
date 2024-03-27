/*
 * Problema: João recebeu seu salário e precisa pagar duas contas que estão atrasadas. Como as contas estão atrasadas, João terá de pagar multa 
 * de 2% sobre cada conta. Faça um programa que calcule e mostre quanto restará do salário de João.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class ContasJoao
    {
        public static void CalculaSalario()
        {
            double salario, conta1, conta2;
            Console.Write("Digite o valor do salário R$ ");
            salario = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor da primeira conta R$ ");
            conta1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor da segunda conta R$ ");
            conta2 = float.Parse(Console.ReadLine());
            salario = salario - (conta1 + conta2 + (conta1 * 0.02 + conta2 * 0.02));
            Console.WriteLine("O salário atual é de R$ " + salario);
            Console.ReadKey();
        }
    }
}
