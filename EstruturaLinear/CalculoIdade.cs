/* 
 * Problema: Faça um programa que receba o ano de nascimento de uma pessoa e o ano atual, calcule e mostre:
 * a) A idade dessa pessoa em anos.
 * b) Quantos anos essa pessoa terá em 2050.
 * c) A idade dessa pessoa em meses.
 * d) A idade dessa pessoa em dias.
 * e) A idade dessa pessoa em semanas.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class CalculoIdade
    {
        public static void CalculoDeIdade()
        {
            int anoAtual, anoNascimento, idadeAnos, idade2050, idadeMeses, idadeDias, idadeSemanas;
            Console.Write("Digite o ano atual >> ");
            anoAtual = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano de nascimento >> ");
            anoNascimento = int.Parse(Console.ReadLine());
            idadeAnos = anoAtual - anoNascimento;
            idade2050 = 2050 - anoNascimento;
            idadeMeses = idadeAnos * 12;
            idadeDias = 365 * idadeAnos;
            idadeSemanas = idadeMeses * 4;
            Console.WriteLine("A idade em anos é de {0}.\nEsta pessoa terá em 2050 {1} anos",idadeAnos,idade2050);
            Console.WriteLine("A idade em meses é de {0}.\nA idade em dias é de {1}.\nA idade em semanas é de {2}", idadeMeses, idadeDias, idadeSemanas);
            Console.ReadKey();
        }
    }
}
