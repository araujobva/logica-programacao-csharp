/*
 * Problema: Um supermercado deseja reajustar os preços de seus produtos usando o seguinte critério: O produto poderá ter seu preço aumentado ou diminuído. Para alterar o preço, o produto deve preencher pelo menos um dos requisitos a seguir.
 * - Se a venda média mensal for < 500 e o preço atual < R$ 30,00 o reajuste será 10% de aumento.
 * - Se a venda média mental for >= 500 e < 1.200 e o preço atual for >= R$ 30,00 e < R$ 80,00 o reajuste será de 15% de aumento.
 * - Se a venda média mensal for >= 1.200 e o preço atual for >= R$ 80,00 o reajuste será de 20% de diminuição.
 * Faça um programa que receba o preço atual e a venda mensal média do produto, calcule e mostre o novo preço.
 * Se esse produto não satisfazer nem uma das proposições, mostre a mensagem "Este produto não terá reajuste."
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class ReajustePreco
    {
        public static void CalculaReajuste()
        {
            double media, valor;
            Console.Write("Digite o valor do produto R$ ");
            valor = double.Parse(Console.ReadLine());
            Console.Write("Digite a média mensal de vendas desse produto >> ");
            media = double.Parse(Console.ReadLine());
            if (media < 500 && valor < 30)
            {
                valor = valor + (valor * 0.1);
                Console.WriteLine("O novo preço deste produto é de R$ " + valor);
            }
            else if (media >= 500 && media < 1.200 && valor >= 30 && valor < 80)
            {
                valor = valor + (valor * 0.15);
                Console.WriteLine("O novo preço deste produto é de R$ " + valor);
            }
            else if (media >= 1.200 && valor >= 80)
            {
                valor = valor - (valor * 0.2);
                Console.WriteLine("O novo preço deste produto é de R$ " + valor);
            }
            else
                Console.WriteLine("Este produto não terá reajuste.");
            Console.ReadKey();
        }
    }
}
