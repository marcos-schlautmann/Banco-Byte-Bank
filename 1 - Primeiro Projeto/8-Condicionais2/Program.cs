using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 1;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode Entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }





            Console.ReadLine();
        }
    }
}
