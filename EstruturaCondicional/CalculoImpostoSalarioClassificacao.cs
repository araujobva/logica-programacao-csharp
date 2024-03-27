/*
 * Problema: Faça um programa que apresente o menu de opções a seguir, permita ao usuário escolher a opçõao desejada, receba os dados necessários para executar a operação 
 * e mostre o resultado. Verifique se as possibilidade de opção é válida. 
 * Menu de opções:
 * 1. Imposto.
 * 2. Novo Salário.
 * 3. Classificação.
 *
 * Na Opção 1: receber o salário de um funcionário, calcular e mostrar o valor do imposto usando as regras a seguir.
 * - Se os salário for menor que R$ 500,00 o percentual do imposto será 5%.
 * - Se o salário igual a R$ 500,00 a R$ 849,00 o percentual do imposto será 10%.
 * - Igual ou acima de R$ 850,00 o percentual será de 15%.
 *
 * Na opção 2: Receber o salário de um funcionário, calcular e mostrar o valor do novo salário, usando as regras abaixo:
 * - Maiores que R$ 1.500,00 aumento de R$ 25,00.
 * - De R$ 750,00 (inclusive) a R$ 1.500,00 (inclusive) aumento de R$ 50,00.
 * - De R$ 450,00 (inclusive) a R$ 750,00 aumento de 75,00.
 * - Menores que R$ 450,00 aumento de R$ 100,00.
 * 
 * Na opção 3: Receber o salário de um funcionário e mostrar sua classificação usando a tabela abaixo.
 * - Salário até R$ 700,00 (inclusive) a classifação será Mal remunerado.
 * - Salário maior que R$ 700,00 a classificação será Bem remunerado.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class CalculoImpostoSalarioClassificacao
    {
        public static void Calcula()
        {
            int op;
            double salario, imposto = 0;
            Console.WriteLine("Digite a opção desejada.");
            Console.Write("1. Imposto.\n2. Novo Salário.\n3. Classificação.\n>> ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Write("Digite o valor do salário R$ ");
                    salario = double.Parse(Console.ReadLine());
                    if (salario < 500)
                        imposto = salario * 0.5;
                    else if (salario >= 500 && salario <= 849)
                        imposto = salario * 0.1;
                    else if (salario >= 850)
                        imposto = salario * 0.15;
                    Console.WriteLine("O valor do imposto é de >> " + imposto);
                    break;
                case 2:
                    Console.Write("Digite o valor do salário R$ ");
                    salario = double.Parse(Console.ReadLine());
                    if (salario > 1500)
                        salario = salario + 25;
                    else if (salario >= 750 && salario <= 1500)
                        salario = salario + 50;
                    else if (salario >= 450 && salario < 750)
                        salario = salario + 75;
                    else if (salario < 450)
                            salario = salario + 100;
                    Console.WriteLine("O valor do novo salário é de R$ " + salario);
                    break;
                case 3:
                    Console.Write("Digite o valor do salário R$ ");
                    salario = double.Parse(Console.ReadLine());
                    if (salario <= 700)
                        Console.WriteLine("Mal remunerado.");
                    else
                        Console.WriteLine("Bem remunerado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
