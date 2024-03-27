//Problema: Faça um programa que receba três notas, calcule e mostre a média aritmética entre elas.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class MediaAritmetica
    { 
        public static void CalculaMediaAritmetica()
        {
            double nota1, nota2, nota3, media;
            Console.Write("Digite a primeira nota >> ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota >> ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota >> ");
            nota3 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("A média aritmética entre as notas é de >> " + media);
            Console.ReadKey();
        }
    }
}
