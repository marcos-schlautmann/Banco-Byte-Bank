using BitBankFuncionarios.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BitBankFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            carlos.Nome = "Carlos";
            gerenciador.Registrar(carlos);

            carlos.AumentarSalario();
            Console.WriteLine("Novo Salário de Carlos é = " + "R$" + carlos.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            gerenciador.Registrar(roberta);

            roberta.AumentarSalario();
            Console.WriteLine("Novo Salário de Roberta é = " + "R$" + roberta.Salario);


            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine("Total de Bonificações = " + "R$" + gerenciador.GetTotalBonificacao());




            Console.ReadLine();
        }
    }
}
