//Problema: Faça um programa que receba três notas e seus respectivos pesos, calcule e mostre a média ponderada dessas notas.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class MediaPonderadaNotas
    {
        public static void CalculaMediaPonderada()
        {
            double nota1, nota2, nota3, peso1, peso2, peso3, mediaPonderada;
            Console.Write("Digite a primeira nota >> ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota >> ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota >> ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite o peso da primeira nota >> ");
            peso1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o peso da segunda nota >> ");
            peso2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o pesoa da terceira nota >> ");
            peso3 = double.Parse(Console.ReadLine());
            mediaPonderada = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
            Console.WriteLine("A média ponderada é de >> " + mediaPonderada);
            Console.ReadKey();
        }
    }
}
