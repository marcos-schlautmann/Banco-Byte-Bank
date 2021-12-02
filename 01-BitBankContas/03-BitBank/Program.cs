using System;

namespace _03_BitBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadaGabriela = new ContaCorrente();
            contadaGabriela.titular = "Gabriela";
            contadaGabriela.agencia = 863;
            contadaGabriela.numero = 863452;

            ContaCorrente contadaGabrielaCosta = new ContaCorrente();
            contadaGabriela.titular = "Gabriela";
            contadaGabriela.agencia = 863;
            contadaGabriela.numero = 863452;

            Console.WriteLine(contadaGabriela == contadaGabrielaCosta);

            contadaGabriela = contadaGabrielaCosta;
            Console.WriteLine(contadaGabriela == contadaGabrielaCosta);


            contadaGabriela.saldo = 300;
            Console.WriteLine(contadaGabriela.saldo);
            Console.WriteLine(contadaGabrielaCosta.saldo);

            if(contadaGabriela.saldo >= 100)
            {
                contadaGabriela.saldo -= 100;
            }


            






            Console.ReadLine();
        }
    }
}
