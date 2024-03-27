/*
 * Problema: Faça um programa que receba:
 * - O código do estado de origem de carga de um caminhão, supondo que a digitação do código do estado seja sempre válida, ou seja, um número inteiro entre 1 e 5.
 * - O peso da carga do caminhão em toneladas.
 * - O código da carga, supondo que a digitação do código da carga seja sempre válida, ou seja, um número inteiro entre 10 e 40.
 * 
 * ----------------
 * Código do estado
 * ----------------
 * - Se o código do estado for 1 o imposto será de 35%.
 * - Se o código do estado for 2 o imposto será de 25%.
 * - Se o código do estado for 3 o imposto será de 15%.
 * - Se o código do estado for 4 o imposto será de 5%.
 * - Se o código do estado for 5 o imposto será de Isento.
 * 
 * ---------------
 * Código da carga
 * ---------------
 * - 10 a 20 toneladas o preço do quilo será de R$ 100,00.
 * - 21 a 30 toneladas o preço do quilo será de R$ 250,00.
 * - 31 a 40 toneladas o preço do quilo será de R$ 340,00.
 * 
 * Calcule e mostre:
 * - O peso da carga do caminhão convertido em quilos.
 * - O preço da carga do caminhão.
 * - O valor do imposto, sabendo-se que o imposto é cobrado sobre o preço da carga do caminhão e que depende do estado de origem.
 * - O valor total transportado pelo caminhão, carga mais imposto.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class CargaCaminhao
    {
        public static void Calcula()
        {
            int codEstado, codCarga;
            double pesoCarga, imposto = 0, quilo, precoCargaImposto = 0, precoCarga = 0;
            Console.Write("Digite o código de estado de origem entre 1 e 5 >> ");
            codEstado = int.Parse(Console.ReadLine());
            Console.Write("Digite o peso em toneladas da carga do caminhão >> ");
            pesoCarga = double.Parse(Console.ReadLine());
            Console.Write("Digite o código da carga entre 10 e 40 >> ");
            codCarga = int.Parse(Console.ReadLine());
            quilo = pesoCarga * 1000; //Converte o peso em toneladas para quilos.
            if (pesoCarga >= 10 && pesoCarga <= 20) //Calcula o valor do preço da carga.
                precoCarga = 100 * quilo;
            else if (pesoCarga >= 21 && pesoCarga <= 30)
                precoCarga = 250 * quilo;
            else if (pesoCarga >= 31 && pesoCarga <= 40)
                precoCarga = 340 * quilo;
            else
                Console.WriteLine("Erro.");
            if(codEstado == 1) //Calcula o valor do imposto e o valor final, preço do valor da carga mais imposto.
            {
                imposto = (precoCarga * 0.35);
                precoCargaImposto = imposto + precoCarga;
            }else if(codEstado == 2)
            {
                imposto = (precoCarga * 0.25);
                precoCargaImposto = imposto + precoCarga;
            }else if(codEstado == 3)
            {
                imposto = (precoCarga * 0.15);
                precoCargaImposto = imposto + precoCarga;
            }else if(codEstado == 4)
            {
                imposto = (precoCarga * 0.05);
                precoCargaImposto = imposto + precoCarga;
            }else if(codEstado == 5)
            {
                imposto = 0;
                precoCargaImposto = imposto + precoCarga;
            }
            else
            {
                Console.WriteLine("Código inválido!");
            }
            Console.WriteLine("O peso do caminhão convertido em quilos é de {0} quilos.", quilo);
            Console.WriteLine("O preço da carga do caminhão sem imposto é de " + precoCarga);
            Console.WriteLine("O valor do imposto é de R$ " + imposto);
            Console.WriteLine("O valor da carga do caminhão mais imposto é de R$ " + precoCargaImposto);
            Console.ReadKey();
        }
    }
}
