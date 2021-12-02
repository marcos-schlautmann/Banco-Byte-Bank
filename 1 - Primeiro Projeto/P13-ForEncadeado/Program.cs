using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13");

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Uma forma diferente de fazer o triangulo de asteriscos

            //for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            //{
            //    for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            //    {
            //        Console.Write("*");
            //        if (contadorColuna >= contadorLinha)
            //            break;
            //    }
            //    Console.WriteLine();
            //}


            Console.ReadLine();
        }
    }
}
