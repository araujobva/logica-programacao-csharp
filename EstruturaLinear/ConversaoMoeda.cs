/*
 * Problema: Faça um programa que receba a quantidade de dinheiro em reais que uma pessoa que vai viajar possui. Essa pessoa vai passar por vários 
 * países e precisa converter seu dinheiro em dólares, marco alemão e libra esterlina. Sabe-se que a cotação do dólar é de R$ 1,80, do marco alemão 
 * é de R$ 2,00 e da libra esterlina é de R$ 1,57. O programa deve fazer as conversões e mostrá-las.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class ConversaoMoeda
    {
        public static void CalculaConversao()
        {
            double reais, dolares, marco, libra;
            Console.Write("Digite o valor em reais para conversão R$ ");
            reais = double.Parse(Console.ReadLine());
            dolares = reais / 1.80;
            marco = reais / 2;
            libra = reais / 1.57;
            Console.WriteLine("O valor em reais {0} convertido em dólares é de R$ {1}", reais, dolares);
            Console.WriteLine("O valor em reais {0} convertido em marco é de R$ {1}", reais, marco);
            Console.WriteLine("O valor em reais {0} convertido em libra é de R$ {1}", reais, libra);
            Console.ReadKey();
        }
    }
}
