using System;

namespace _2___CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 -  Criando Variaveis!");

            int idade;
            idade = 29;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade + "!");


            Console.WriteLine("Execução finalizada. Tecle Enter para sair...");
            Console.ReadLine();
        }
    }
}
