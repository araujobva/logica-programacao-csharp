/* 
 * Problema: Sabe-se que:
 * 1 pé = 12 polegadas
 * 1 jarda = 3 pés
 * 1 milha = 1.760 jardas
 * Faça um programa que receba uma medida em pés, faça as conversões a seguir e mostre os resultados.
 * a) Polegadas.
 * b) Jardas.
 * c) Milhas.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class ConversaoMedidas
    {
        public static void ConverteMedidas()
        {
            double pes, polegadas, jardas, milhas;
            Console.Write("Digite a medida em pés >> ");
            pes = double.Parse(Console.ReadLine());
            polegadas = pes * 12;
            jardas = pes / 3;
            milhas = jardas / 1760;
            Console.WriteLine("A quantidade de pés digitada {0} convertida em polegadas é de {1} ", pes , polegadas);
            Console.WriteLine("A quantidade de pés digitada {0} convertida em jardas é de {1} ", pes, jardas);
            Console.WriteLine("A quantidade de pés digitada {0} convertida em milhas é de {1} ", pes, milhas);
            Console.ReadKey();
        }
    }
}
