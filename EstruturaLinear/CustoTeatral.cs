/*
 * Problema: Faça um programa que receba o custo de um espetáculo teatral e o preço do convite desse espetáculo. 
 * Esse programa deve calcular e mostrar a quantidade de convites que devem ser vendidos para que, pelo menos, o custo do espetáculo seja alcançado. 
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class CustoTeatral
    {
        public static void CalculaCustoTeatro()
        {
            double custoPeca, custoConvite, quantConvites;
            Console.Write("Digite o custo da peça de teatro R$ ");
            custoPeca = double.Parse(Console.ReadLine());
            Console.Write("Digite o custo do convite R$ ");
            custoConvite = double.Parse(Console.ReadLine());
            quantConvites = custoPeca / custoConvite;
            Console.WriteLine("É necessário vender {0} convites para que o custo da peça seja alcançado.", quantConvites);
            Console.ReadKey();
        }
    }
}
