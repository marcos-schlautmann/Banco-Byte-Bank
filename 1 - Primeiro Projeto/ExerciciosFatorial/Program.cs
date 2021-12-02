using System;

namespace ExerciciosFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimindo de 1! a 10!");

            int fatorial = 1;

            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
            Console.ReadLine();
        }
    }
}

