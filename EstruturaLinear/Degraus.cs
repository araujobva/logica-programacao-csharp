/*
 * Problema: Cada degrau de uma escada tem X de altura. Faça um programa que receba essa altura e a altura que o usuário 
 * deseja alcançar subindo a escada. Calcule e mostre quantos degraus o usuário deverá subir para atingir seu objetivo, sem se 
 * preocupar com a altura do usuário.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class Degraus
    {
        public static void CalculaAltura()
        {
            double alturaDegrau, alturaDesejada, quantDegraus;
            Console.Write("Digite a altura de cada degrau em centímetros >> ");
            alturaDegrau = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura desejada em centímetros para ser alcançada >> ");
            alturaDesejada = double.Parse(Console.ReadLine());
            quantDegraus = alturaDesejada / alturaDegrau;
            Console.WriteLine("O usuário terá que subir {0} degraus para alcançar a altura de {1} centímetros." , quantDegraus, alturaDesejada);
            Console.ReadKey();
        }
    }
}
