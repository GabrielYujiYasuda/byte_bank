using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;

            TotalFuncionarios++;
        }

        public virtual double Bonificacao()
        {
            return Salario * 0.1;
        }

        public abstract void AumentarSalario();
    }
}
