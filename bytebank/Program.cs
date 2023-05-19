using bytebank;
using System.Runtime.CompilerServices;

ContaCorrente contaGabriel = new ContaCorrente();
contaGabriel.numero_agencia = 123;
contaGabriel.conta = "1919-Y";
contaGabriel.titular = "Gabriel Yasuda";
contaGabriel.saldo = 100;

Console.WriteLine("Conta do {0}", contaGabriel.titular);
Console.WriteLine("Numero agencia: {0}", contaGabriel.numero_agencia);
Console.WriteLine("Conta: {0}", contaGabriel.conta);
Console.WriteLine("Titular da conta: {0}", contaGabriel.titular);
Console.WriteLine("Saldo: {0:0.0}", contaGabriel.saldo);

Console.WriteLine("\nOPERAÇÕES\n----------");

//contaGabriel.Depositar(100);
//Console.WriteLine("Novo saldo: {0:0.0}", contaGabriel.saldo);

//if (contaGabriel.Sacar(30) == true)
//{
//    Console.WriteLine("Dinheiro sacado com sucesso!");
//} else
//{
//    Console.WriteLine("Saldo insificiente!");
//}

Console.WriteLine("TRANSFERENCIA");
ContaCorrente contaLaura = new ContaCorrente(123, "3000-A", "Laura Gracie", 0);

contaGabriel.Transferir(contaLaura, 99.50);
Console.WriteLine("Saldo Gabriel: {0:0.0}", contaGabriel.saldo);
Console.WriteLine("Saldo Laura: {0:0.0}", contaLaura.saldo);
