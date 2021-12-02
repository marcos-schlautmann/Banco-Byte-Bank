using BitBankFuncionarios.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBankFuncionarios
{
    public class GerenciadorBonificacao
    {
        private double _totalBonficacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonficacao += funcionario.GetBonificacao();

        }
        public double GetTotalBonificacao()
        {
            return _totalBonficacao;
        }

    }
}
