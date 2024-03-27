/* 
 * Problema: Um trabalhador recebeu seu salário e o depositou em sua conta-corrente bancária. Esse trabalhador emitiu dois cheques 
 * e agora deseja saber seu saldo atual. Sabe-se que cada operação bancária de retirada paga CPMF de 0,38% e o saldo inicial da conta está zerado.
 */

using System;

namespace LogicaProgramacaoCSharp.Problemas.EstruturaLinear
{
    class SaldoAtual
    {
        public static void CalculaSaldo()
        {
            double salario, cheque1, cheque2, cpmf = 0.38, saldoConta = 0;
            Console.Write("Digite o valor do salário recebido R$ ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do primeiro cheque R$ ");
            cheque1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do segundo cheque R$ ");
            cheque2 = double.Parse(Console.ReadLine());
            saldoConta = salario;
            saldoConta = saldoConta - ((cheque1 + cheque2) + (cheque1 * cpmf + cheque2 * cpmf));
            Console.WriteLine("O saldo atual é de R$ " + saldoConta);
            Console.ReadKey();
        }
    }
}
