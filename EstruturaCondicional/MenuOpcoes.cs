/*
 * Problema: Faça um programa que mostre o menu de opções a seguir, receba a opção do usuário e os dados necessários para executar cada operação.
 * Menu de opções:
 * 1 - Somar dois números.
 * 2 - Raiz quadrada de um número.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class MenuOpcoes
    {
        public static void MenuOpcoesSomaRaiz()
        {
            int op;
            Console.Write("Digite 1 para somar 2 valores.\nDigite 2 para calcular a raiz quadrada de um valor.\n>> ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    double v1, v2;
                    Console.Write("Digite o primeiro valor >> ");
                    v1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor >> ");
                    v2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("A soma dos dois valores é " + (v1 + v2));
                    break;
                case 2:
                    double valor;
                    Console.Write("Digite um valor para calcular a raiz quadrada >> ");
                    valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("A raiz quadrada do númeor digitado é " + (Math.Sqrt(valor)));
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
