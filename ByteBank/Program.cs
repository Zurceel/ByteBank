using bytebank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Gabriel Cruz";
conta1.conta = "0001-1";
conta1.numeroAgencia = 14;
conta1.nomeAgencia = "Agencia Central";
conta1.saldo = 450;

ContaCorrente conta2 = new ContaCorrente
{
	titular = "Geovanna Lins",
	conta = "0001-2",
	numeroAgencia = 14,
	nomeAgencia = "Agencia Central",
	saldo = 650
};

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número da Agência: " + conta1.numeroAgencia);
//Console.WriteLine("Nome da Agência: " + conta1.nomeAgencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

//Console.WriteLine("Titular: " + conta2.titular);
//Console.WriteLine("Conta: " + conta2.conta);
//Console.WriteLine("Número da Agência: " + conta2.numeroAgencia);
//Console.WriteLine("Nome da Agência: " + conta2.nomeAgencia);
//Console.WriteLine("Saldo: " + conta2.saldo);

Console.WriteLine("Valor antes de sacar " + conta2.saldo);
conta2.Depositar(100);
Console.WriteLine("Valor depois do saque " + conta2.saldo);

Console.ReadKey();

