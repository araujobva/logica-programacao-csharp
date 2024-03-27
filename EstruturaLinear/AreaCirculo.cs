//Problema: Faça um programa que calcule e mostre a área de um círculo. Sabe-se que: Area = Pi * Raio(Ao quadrado).

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class AreaCirculo
    {
        public static void CalculaAreaCirculo()
        {
            double pi = 3.1415, area, raio;
            Console.Write("Digite o raio >> ");
            raio = double.Parse(Console.ReadLine()); 
            area = pi * (raio * raio);
            Console.WriteLine("A área do círcuo é de "+area);
            Console.ReadKey();
        }
    }
}
