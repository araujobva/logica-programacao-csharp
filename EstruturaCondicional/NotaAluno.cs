/*
 * Problema: Faça um programa que receba três notas de um aluno, calcule e mostre a média aritmética e a mensagem que segue abaixo. 
 * 0,0 a 2,9 Reprovado
 * 3,0 a 6,9 Exame
 * 7,0 a 10,0 Aprovado
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class NotaAluno
    {
        public static void CalculaMedia()
        {
            float nota1, nota2, nota3, media;
            Console.Write("Digite a primeira nota >> ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota >> ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota >> ");
            nota3 = float.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3) / 3;
            if (media <= 2.9)
                Console.WriteLine("Reprovado");
            else if (media >= 3 || media <= 6.9)
                Console.WriteLine("Exame");
            else if (media >= 7 || media <= 10)
                Console.WriteLine("Aprovado");
            Console.ReadKey();
        }
    }
}
