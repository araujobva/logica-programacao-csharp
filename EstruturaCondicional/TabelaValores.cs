/*
 * Problema: Faça um programa que receba quatro valores, I, A, B e C. I é um valor inteiro e positivo e A, B e C são valores reais. 
 * Escreva os números A, B e C obedecendo à tabela a seguir.
 * - Se o valor de I for 1, mostre A, B e C em ordem crescente.
 * - Se o valor de I for 2, mostre A, B e C em ordem decrescente.
 * - Se o valor de I for 3 ou maior, o maior número fica entre os outros dois números.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class TabelaValores
    {
        public static void CalculaOrdemValores()
        {
            int i;
            double a, b, c;
            Console.Write("Digite um valor inteiro e maior que zero >> ");
            i = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de A >> ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B >> ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C >> ");
            c = double.Parse(Console.ReadLine());
            if(i == 1)
            {
                if(a > b && b > c)
                {
                    Console.WriteLine("Valores em ordem crescente {0} - {1} - {2}", c, b, a);
                }else if(a > c && c > b)
                {
                    Console.WriteLine("Valores em ordem crescente {0} - {1} - {2}", b, c, a);
                }else if(b > a && a > c)
                {
                    Console.WriteLine("Valores em ordem crescente {0} - {1} - {2}", c, a, b);
                }else if (b > c && c > a)
                {
                    Console.WriteLine("Valores em ordem crescente {0} - {1} - {2}", a, c, b);
                }else if(c > a && a > b)
                {
                    Console.WriteLine("Valores em ordem crescente {0} - {1} - {2}", b, a, c);
                }else if(c > b && b > a)
                {
                    Console.WriteLine("Valores em ordem crescente {0} - {1} - {2}", a, b, c);
                }
            }
            if(i == 2)
            {
                if (a > b && b > c)
                {
                    Console.WriteLine("Valores em ordem crescente {0} - {1} - {2}", a, b, c);
                }
                else if (a > c && c > b)
                {
                    Console.WriteLine("Valores em ordem crescente {0} - {1} - {2}", a, c, b);
                }
                else if (b > a && a > c)
                {
                    Console.WriteLine("Valores em ordem crescente {0} - {1} - {2}", b, a, c);
                }
                else if (b > c && c > a)
                {
                    Console.WriteLine("Valores em ordem crescente {0} - {1} - {2}", b, c, a);
                }
                else if (c > a && a > b)
                {
                    Console.WriteLine("Valores em ordem crescente {0} - {1} - {2}", c, a, b);
                }
                else if (c > b && b > a)
                {
                    Console.WriteLine("Valores em ordem crescente {0} - {1} - {2}", c, b, a);
                }
            }
            if(i == 3)
            {
                if (a > b && b > c)
                {
                    Console.WriteLine("O maior número ficando entre os outros dois números {0} - {1} - {2}", b, a, c);
                }
                else if (a > c && c > b)
                {
                    Console.WriteLine("O maior número ficando entre os outros dois números {0} - {1} - {2}", c, a, b);
                }
                else if (b > a && a > c)
                {
                    Console.WriteLine("O maior número ficando entre os outros dois números {0} - {1} - {2}", a, b, c);
                }
                else if (b > c && c > a)
                {
                    Console.WriteLine("O maior número ficando entre os outros dois números {0} - {1} - {2}", c, b, a);
                }
                else if (c > a && a > b)
                {
                    Console.WriteLine("O maior número ficando entre os outros dois números {0} - {1} - {2}", a, c, b);
                }
                else if (c > b && b > a)
                {
                    Console.WriteLine("O maior número ficando entre os outros dois números {0} - {1} - {2}", b, c, a);
                }
            }
            Console.ReadKey();
        }
    }
}
