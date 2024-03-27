/*
 * Problema: Faça um programa que receba o código correspondente ao cargo de um funcionário e seu salário atual, mostre o cargo, o valor do aumento e seu novo salário. 
 * Os cargos estão abaixo. NOTA: Se o código digitado não for válido, informe ao usuário.
 * - Código 1, cargo Escrituário, percentual 50%.
 * - Código 2, cargo Secretário, percentual 35%.
 * - Código 3, cargo Caixa, percentual 20%.
 * - Código 4, cargo Gerente, percentual 10%.
 * - Código 5, cargo Diretor, não tem aumento.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class AumentoSalarioCodigo
    {
        public static void CalculaNovoSalario()
        {
            double salario;
            int cod;
            Console.Write("Digite o valor do salário R$ ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Digite o código do funcionário >> ");
            cod = int.Parse(Console.ReadLine());
            switch (cod)
            {
                case 1:
                    salario = salario + (salario * 0.5);
                    Console.WriteLine("Cargo escrituário\nSalário R$ " + salario);
                    break;
                case 2:
                    salario = salario + (salario * 0.35);
                    Console.WriteLine("Cargo secretário\nSalário R$ " + salario);
                    break;
                case 3:
                    salario = salario + (salario * 0.2);
                    Console.WriteLine("Cargo caixa\nSalário R$ " + salario);
                    break;
                case 4:
                    salario = salario + (salario * 0.1);
                    Console.WriteLine("Cargo gerente\nSalário R$ " + salario);
                    break;
                case 5:
                    Console.WriteLine("Cargo diretor\nSalário R$ " + salario);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
