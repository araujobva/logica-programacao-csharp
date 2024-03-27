/* 
 * Problema: O custo ao consumidor de um carro novo é a soma do preço de fábrica com o percentual de lucro do distribuidor e dos impostos aplicados ao preço de fábrica. 
 * Faça um programa que receba o preço de fábrica de um veículo, o percentual de lucro do distribuidor e o percentual de impostos. Calcule e mostre:
 * a) O valor correspondente ao lucro do distribuidor.
 * b) O valor correspondente aos impostos.
 * c) O preço final do veículo.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class CalculoValorVeiculo
    {
        public static void CalculandoValor()
        {
            float precoFabrica, percDistribuidor, percImposto, lucroDistribuidor, imposto, precoFinal;
            Console.Write("Digite o preço de fábrica do automóvel R$ ");
            precoFabrica = float.Parse(Console.ReadLine());
            Console.Write("Digite o percentual de lucro do distribuidor >> ");
            percDistribuidor = float.Parse(Console.ReadLine());
            percDistribuidor = percDistribuidor / 100;
            Console.Write("Digite o percentual de imposto >> ");
            percImposto = float.Parse(Console.ReadLine());
            percImposto = percImposto / 100;
            lucroDistribuidor = precoFabrica * percDistribuidor;
            imposto = precoFabrica * percImposto;
            precoFinal = precoFabrica + lucroDistribuidor + imposto;
            Console.WriteLine("O lucro do distribuidor é de R$ " + lucroDistribuidor);
            Console.WriteLine("O valor correspondente aos impostos é de R$ " + imposto);
            Console.WriteLine("O preço final do veículo é de R$ " + precoFinal);
            Console.ReadKey();
        }
    }
}
