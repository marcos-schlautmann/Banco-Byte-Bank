using System;

namespace _5_CaracteresETextos2
{
    public class Program
    {

        public static void Main(string[] args)
        {

            char letra = 'a';
            Console.WriteLine(letra);

            int idade = 100;

            char valor = (char)65;                    // Não Compila!
            Console.WriteLine(valor);

            valor = (char)(valor + 1);         // Compila!
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia ";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);
        }
    }
}


