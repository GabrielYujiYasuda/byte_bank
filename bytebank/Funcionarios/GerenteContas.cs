﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class GerenteContas:Funcionario
    {
        public GerenteContas(string cpf, double salario): base(cpf, 5000)
        {
            
        }
    }
}
