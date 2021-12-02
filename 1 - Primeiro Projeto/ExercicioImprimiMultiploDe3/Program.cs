using System;

namespace ExercicioImprimiMultiploDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimindo múltiplos de 3 de 1 a 100");

            int constante = 3;

            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % constante == 0)
                {
                    Console.WriteLine(numero);
                }

            }
            Console.ReadLine();
        }
    }
}
