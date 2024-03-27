/*
 * Problema: Faça um programa que receba o valor da poupança, o valor de um depósito e a porcentagem do rendimento
 * da poupança, calcule e mostre o valor da poupança com o seu futuro rendimento.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class DepositoJuros
    {
        public static void CalculaValorPoupança()
        {
            double valorPoupanca, valorDeposito, percRendimento;
            Console.Write("Digite o valor da poupança R$ ");
            valorPoupanca = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do depósito R$ ");
            valorDeposito = double.Parse(Console.ReadLine());
            Console.Write("Digite a porcentagem de rendimento mensal da poupança >> ");
            percRendimento = double.Parse(Console.ReadLine());
            percRendimento = percRendimento / 100;
            valorPoupanca = valorPoupanca + valorDeposito;
            valorPoupanca = valorPoupanca + (valorPoupanca * percRendimento);
            Console.WriteLine("O valor da poupança mais o seu rendimento é de R$ " + valorPoupanca);
            Console.ReadKey();
        }
    }
}
