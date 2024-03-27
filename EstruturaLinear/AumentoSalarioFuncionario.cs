//Problema: Faça um programa que receba o salário de um funcionário e o percentual de aumento, calcule e mostre o valor do aumento e o novo salário.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class AumentoSalarioFuncionario
    {
        public static void CalculaAumentoSalario()
        {
            double perc, salarioAtual, novoSalario;
            Console.Write("Digite o salario atual do funcionário R$ ");
            salarioAtual = double.Parse(Console.ReadLine());
            Console.Write("Digite o percentual de aumento do funcionário >> ");
            perc = double.Parse(Console.ReadLine()) / 100;
            novoSalario = salarioAtual + (salarioAtual * perc);
            Console.WriteLine("O novo salario do funcionário é de R$ " + novoSalario);
            Console.ReadKey();
        }
    }
}
