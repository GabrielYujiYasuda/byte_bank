using bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Utilitario
{
    internal class GerenciadorBonificacao
    {
        public double  TotalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.Bonificacao();
        }
    }
}
