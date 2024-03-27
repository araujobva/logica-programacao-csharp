/*
 * Problema: Dados três valores X, Y e Z, verificar se eles podem ser os comprimentos dos lados de um triângulo, e se forem, verificar se é um triângulo equilátero, isósceles ou escaleno. 
 * Se eles não formarem um triângulo escreva uma mensagem. Considerar que:
 * - O comprimento de cada lado de um triângulo é menor que a soma dos outros dois lados.
 * - Chama-se triângulo equilátero o triângulo que tem três lados iguais.
 * - Chama-se triângulo isósceles o triângulo que tem o comprimento de dois lados iguais.
 * - Chama-se triângulo escaleno o triângulo que tem os três lados diferentes.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class LadosTriangulo
    {
        public static void CalculaLadoTriangulo()
        {
            double x, y, z;
            bool teste = false;
            Console.Write("Digite o lado X do triângulo >> ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Digite o lado Y do triângulo >> ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Digite o lado Z do triângulo >> ");
            z = double.Parse(Console.ReadLine());
            if (x + y > z && x + z > y && y + z > x)
            {
                teste = true;
                if (teste)
                {
                    if (x == y && x == z & z == y)
                    {
                        Console.WriteLine("Triângulo equilátero.");
                    }
                    else if (x == y || x == z || y == z)
                    {
                        Console.WriteLine("Triângulo Isósceles");
                    }
                    else if (x != y && x != z && y != z)
                    {
                        Console.WriteLine("Triângulo Escaleno");
                    }
                }
                else
                {
                    Console.WriteLine("Esses valores não montam um triângulo.");
                }
            }

            Console.ReadKey();
        }
    }
}
