//Problema: Faça um programa que receba o salário de um funcionário, calcule e mostre o novo salário, sabendo-se que este sofreu um aumento de 25%.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class AumentoSalario
    {
        public static void CalculaSalario()
        {
            double salario, percAumento = 0.25, novoSalario;
            Console.Write("Digite o salário atual do funcionário R$ ");
            salario = double.Parse(Console.ReadLine());
            novoSalario = salario + (salario * percAumento);
            Console.WriteLine("O novo salário do funcionário é de R$ {0}",novoSalario);
            Console.ReadKey();
        }
    }
}
