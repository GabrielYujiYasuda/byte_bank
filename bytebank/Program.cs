using bytebank.Contas;
using bytebank.Funcionarios;
using bytebank.Titular;
using bytebank.Utilitario;
using System.Runtime.CompilerServices;

#region
//ContaCorrente contaGabriel = new ContaCorrente();
//contaGabriel.numero_agencia = 123;
//contaGabriel.conta = "1919-Y";
//contaGabriel.titular = "Gabriel Yasuda";
//contaGabriel.saldo = 100;

//Console.WriteLine("Conta do {0}", contaGabriel.titular);
//Console.WriteLine("Numero agencia: {0}", contaGabriel.numero_agencia);
//Console.WriteLine("Conta: {0}", contaGabriel.conta);
//Console.WriteLine("Titular da conta: {0}", contaGabriel.titular);
//Console.WriteLine("Saldo: {0:0.0}", contaGabriel.saldo);

//Console.WriteLine("\nOPERAÇÕES\n----------");

//contaGabriel.Depositar(100);
//Console.WriteLine("Novo saldo: {0:0.0}", contaGabriel.saldo);

//if (contaGabriel.Sacar(30) == true)
//{
//    Console.WriteLine("Dinheiro sacado com sucesso!");
//} else
//{
//    Console.WriteLine("Saldo insificiente!");
//}

//Console.WriteLine("TRANSFERENCIA");
//ContaCorrente contaLaura = new ContaCorrente(123, "3000-A", "Laura Gracie", 0);

//contaGabriel.Transferir(contaLaura, 99);
//Console.WriteLine("Saldo Gabriel: {0:0.0}", contaGabriel.saldo);
//Console.WriteLine("Saldo Laura: {0:0.0}", contaLaura.saldo);

//Cliente cliente = new Cliente();
//cliente.nome = "Andre Silva";
//cliente.CPF = "1234566789";
//cliente.profissao = "Analista";

//ContaCorrente contaAndre = new ContaCorrente();
//contaAndre.titular = cliente;
//contaAndre.conta = "1234-B";
//contaAndre.numero_agencia = 15;
//contaAndre.saldo = 100;

//Console.WriteLine("Titular: " + contaAndre.titular.nome);
//Console.WriteLine("CPF: " + contaAndre.titular.CPF);
//Console.WriteLine("Profissao: " + contaAndre.titular.profissao);
//Console.WriteLine("Conta: " + contaAndre.conta);
//Console.WriteLine("Numero Agencia: " + contaAndre.numero_agencia);
//Console.WriteLine("Saldo: " + contaAndre.saldo);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();

//conta2.titular.nome = "Jose Miranda";
//conta2.titular.profissao = "Desenvovledor";
//conta2.titular.CPF = "98723412-43";
//conta2.numero_agencia = 123;
//conta2.conta = "456-X";
//conta2.saldo = 100;

//Console.WriteLine("Nome do titular: {0}", conta2.titular.nome);
//Console.WriteLine("Saldo: {0:0.0}", conta2.saldo);

//ContaCorrente conta1 = new ContaCorrente(1, "111-X");
//ContaCorrente conta2 = new ContaCorrente(2, "222-X");
//ContaCorrente conta3 = new ContaCorrente(3, "333-X");
//conta3.DefinirSaldo(1256);
//Console.WriteLine(conta3.Saldo);

//ContaCorrente contasCriadas = new ContaCorrente();

//Console.WriteLine("Total de contas criadas: {0}", ContaCorrente.TotalContasCriadas);
#endregion
//Funcionario gabriel = new Funcionario("123123123", 1000);
//gabriel.Nome = "Gabriel Yuji";
//Console.WriteLine("GABRIEL");
//Console.WriteLine("Salário: {0:0.0}", gabriel.Salario);
//Console.WriteLine("Bonificação: {0:0.0}", gabriel.Bonificacao());

Diretor diretor = new Diretor("123123123");
diretor.Nome = "Diretor";
Console.WriteLine("\nDIRETOR");
Console.WriteLine("Salário: {0:0.0}", diretor.Salario);
Console.WriteLine("Bonificação: {0:0.0}", diretor.Bonificacao());

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
//gerenciador.Registrar(gabriel);
gerenciador.Registrar(diretor);

//gabriel.AumentarSalario();
//Console.WriteLine("Novo salario: " + gabriel.Salario);

Console.WriteLine("Total: " + gerenciador.TotalBonificacao);
Console.WriteLine(Funcionario.TotalFuncionarios);