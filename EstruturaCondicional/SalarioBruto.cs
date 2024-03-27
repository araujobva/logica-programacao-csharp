/*
 * Problema: Faça um programa que receba o valor do salário mínimo, o turno de trabalho (M - Matutino, V - Vespertino ou N - Noturno), e a categoria (O - Operário, G - Gerente). 
 * Calcule e mostre o salário bruto de acordo com as regra abaixo:
 * - O bônus no salário, de acordo com a tabela a seguir:
 * - M - Matutino 10% a mais no valor do salário mínimo.
 * - V - Vespertino 15% a mais no valor do salário mínimo.
 * - N - Noturno 20% a mais no valor do salário mínimo.
 * NOTA: Se for operário recebe mais 2% de aumento, se for gerente recebe 5%.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class SalarioBruto
    {
        public static void CalculaSalario()
        {
            double salarioMinimo;
            char turno, categoria;
            Console.Write("Digite o valor do salário mínimo R$ ");
            salarioMinimo = double.Parse(Console.ReadLine());
            Console.Write("Digite o turno de trabaho.\n- M para matutino.\n- V para vespertino.\n- N para noturno\n>> ");
            turno = char.Parse(Console.ReadLine());
            Console.Write("Digite a categoria.\n- O - para operário.\n- G para gerente.\n>> ");
            categoria = char.Parse(Console.ReadLine());
            if(turno == 'M' || turno == 'm')
            {
                if(categoria == 'O' || categoria == 'o')
                {
                    salarioMinimo = salarioMinimo + (salarioMinimo * 0.1) + (salarioMinimo * 0.02);
                    Console.WriteLine("O valor do novo salário é de R$ " + salarioMinimo);
                }else if(categoria == 'G' || categoria == 'g')
                {
                    salarioMinimo = salarioMinimo + (salarioMinimo * 0.1) + (salarioMinimo * 0.05);
                    Console.WriteLine("O valor do novo salário é de R$ " + salarioMinimo);
                }
            }
            if (turno == 'V' || turno == 'v')
            {
                if (categoria == 'O' || categoria == 'o')
                {
                    salarioMinimo = salarioMinimo + (salarioMinimo * 0.15) + (salarioMinimo * 0.02);
                    Console.WriteLine("O valor do novo salário é de R$ " + salarioMinimo);
                }
                else if (categoria == 'G' || categoria == 'g')
                {
                    salarioMinimo = salarioMinimo + (salarioMinimo * 0.15) + (salarioMinimo * 0.05);
                    Console.WriteLine("O valor do novo salário é de R$ " + salarioMinimo);
                }
            }
            if (turno == 'N' || turno == 'n')
            {
                if (categoria == 'O' || categoria == 'o')
                {
                    salarioMinimo = salarioMinimo + (salarioMinimo * 0.2) + (salarioMinimo * 0.02);
                    Console.WriteLine("O valor do novo salário é de R$ " + salarioMinimo);
                }
                else if (categoria == 'G' || categoria == 'g')
                {
                    salarioMinimo = salarioMinimo + (salarioMinimo * 0.2) + (salarioMinimo * 0.05);
                    Console.WriteLine("O valor do novo salário é de R$ " + salarioMinimo);
                }
            }
            Console.ReadKey();
        }
    }
}
