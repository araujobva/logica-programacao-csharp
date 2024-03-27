/*
 * Problema: Faça um programa que receba o salário e o primeiro nome de um funcionário, calcule e  mostre o nome e o novo salário desse funcionário, acrescido de bonificação e de auxílio-escola.
 * -----------
 * Bonificação
 * -----------
 * - Salário até R$ 500,00 bonificação de 5% do salário.
 * - Entre R$ 500,01 e R$ 1.200,00 bonificação de 12% do salário.
 * - Acima de R$ 1.200,00 sem bonificação.
 * --------------
  * Auxílio-Escola
  * --------------
  * - Salário até R$ 600,00 auxílio-escola de R$ 150,00.
  * - Mais que R$ 600,00 auxílio-escola de R$ 100,00.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class SalarioBonificacao
    {
        public static void CalculaNovoSalario()
        {
            double salario;
            string nome;
            Console.Write("Digite o seu salário R$ ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu nome >> ");
            nome = Console.ReadLine();
            if (salario <= 500) //Calcula bonificação do salário.
                salario = salario + (salario * 0.05);
            else if (salario > 500 && salario <= 1.200)
                salario = salario + (salario * 0.12);
            if (salario <= 600) //Calcula o auxílio escola.
                salario = salario + 150;
            else if (salario > 600)
                salario = salario + 100;
            Console.WriteLine("O nome do funcionário é {0}, seu salário é de R$ {1}", nome, salario);
            Console.ReadKey();
        }
    }
}
