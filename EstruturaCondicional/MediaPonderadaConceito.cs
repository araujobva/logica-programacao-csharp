/*
 * Problema: A nota final de um estudante é calculada a partir de três notas atribuidas respectivamente a um trabalho de laboratório, a uma avaliação 
 * semestral e a um exame final. A média das três notas mencionadas anteriormente obedece aos pesos a seguir: 
 * - Trabalho de Laboratório: Peso 2
 * - Avaliação semestral: Peso 3
 * - Exame final: Peso 5
 * Faça um programa que receba as três notas, calcule e mostre a média ponderada e o conceito que segue abaixo:
 * - Média ponderada de 8.0 a 10.0: Conceito A
 * - Média ponderada de 7.0 a 7.9: Conceito B
 * - Média ponderada de 6.0 a 6.9: Conceito C
 * - Média ponderada de 5.0 a 5.9: Conceito D
 * - Média ponderada de 0.0 a 4.9: Conceito E
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaCondicional
{
    class MediaPonderadaConceito
    {
        public static void CalculaNota()
        {
            float notaTrabalho, pesoTrabalho = 2, notaAvaliacao, pesoAvaliacao = 3, notaExameFinal, pesoExameFinal = 5, mediaPonderada;
            Console.Write("Digite a nota do trabalho >> ");
            notaTrabalho = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota da avaliação >> ");
            notaAvaliacao = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota do exame final >> ");
            notaExameFinal = float.Parse(Console.ReadLine());
            mediaPonderada = (notaTrabalho * pesoTrabalho + notaAvaliacao * pesoAvaliacao + notaExameFinal * pesoExameFinal) / (pesoTrabalho + pesoAvaliacao + pesoExameFinal);
            if (mediaPonderada >= 8 && mediaPonderada <= 10)
            {
                Console.WriteLine("A média ponderada é de " + mediaPonderada);
                Console.WriteLine("Conceito A");
            }
            else if (mediaPonderada >= 7 && mediaPonderada <= 7.9)
            {
                Console.WriteLine("A média ponderada é de " + mediaPonderada);
                Console.WriteLine("Conceito B");
            }
            else if (mediaPonderada >= 6 && mediaPonderada <= 6.9)
            {
                Console.WriteLine("A média ponderada é de " + mediaPonderada);
                Console.WriteLine("Conceito C");
            }
            else if (mediaPonderada >= 5 && mediaPonderada <= 5.9)
            {
                Console.WriteLine("A média ponderada é de " + mediaPonderada);
                Console.WriteLine("Conceito D");
            }
            else if (mediaPonderada <= 4.9)
            {
                Console.WriteLine("A média ponderada é de " + mediaPonderada);
                Console.WriteLine("Conceito E");
            }
            Console.ReadKey();
        }
    }
}
