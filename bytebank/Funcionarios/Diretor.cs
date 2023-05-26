using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Diretor:Funcionario
    {
        
        public Diretor (string cpf): base (cpf, 5000)
        {
            //base.CPF = cpf;
        }

        public override double Bonificacao()
        {
            return Salario + base.Bonificacao();
        }

        public override void AumentarSalario()
        {
            this.Salario = this.Salario + (this.Salario * 0.15);
        }
    }
}
