using System;

namespace _3__CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando Variaveis Ponto Flutuante!");

            double salario = 1200.70;

            Console.WriteLine(salario);

            double idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            idade = 5.0 * 3;
            Console.WriteLine("5.0 * 3 = " + idade);

            Console.WriteLine("A execução a acabou. Tecle Enter para sair...");
            Console.ReadLine();
        }
    }
}
