//Problema: Faça um programa que calcule e mostre a área de um triângulo. Sabe-se que: Area = (base * altura) / 2.

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class AreaTriangulo
    {
        public static void CalculaAreaTriangulo()
        {
            double area, ba, altura;
            Console.Write("Digite a base do triângulo >> ");
            ba = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura do triângulo >> ");
            altura = double.Parse(Console.ReadLine());
            area = (ba * altura) / 2;
            Console.WriteLine("A área do triângulo é de " + area);
            Console.ReadKey();
        }
    }
}
