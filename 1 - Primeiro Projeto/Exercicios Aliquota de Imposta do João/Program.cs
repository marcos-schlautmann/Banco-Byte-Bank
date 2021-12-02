using System;

namespace Exercicios_Aliquota_de_Imposta_do_João
{
    class Programa
    {
        static void Main(string[] args)
        {
            double salario = 2899.99;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("A sua alíquota é de 7,5% e poderá deduzir na declaração o valor de R$ 142,00 !");
            }
            else if (salario > 2800.01 && salario < 3751.0)
            {
                Console.WriteLine("A sua alíquota é de 15% e poderá deduzir na declaração o valor de R$ 350,00 !");
            }
            else if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("A sua alíquota é de 22.5% e poderá deduzir na declaração o valor de R$ 636,00 !");
            }
            else
            {
                Console.WriteLine("Para valores acima de R$ 4664,00 ou abaixo de R$ 1900,00 consulte o site da Receita Federal !");
            }
            
            Console.ReadLine();




        }
    }
}

