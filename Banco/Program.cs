
using Banco.Modelos;
using Banco.Relatorios;

CriarConta();
// Depositar();
// Sacar();
// Transferir();
// RelatorioTotalizadorDeContas();
// RelatorioTotalizadorDeTributos();

void CriarConta()
{
    var conta1 = new ContaCorrente("Joao");
    conta1.Depositar(10);
    Console.WriteLine(conta1.Numero);

    var conta2 = new ContaCorrente("Joao");
    Console.WriteLine(conta2.Numero);

    var conta3 = new ContaCorrente("Joao");
    Console.WriteLine(conta3.Numero);
}

void Depositar()
{
    ContaCorrente conta1 = new("Leo");
    Console.WriteLine(conta1.Saldo);
    conta1.Depositar(10);
    Console.WriteLine(conta1.Saldo);
}

void Sacar()
{
    ContaPoupanca conta1 = new("Leo");
    conta1.Depositar(10);
    Console.WriteLine(conta1.Saldo);
    conta1.Sacar(5);
    Console.WriteLine(conta1.Saldo);
}

void Transferir()
{
    ContaPoupanca conta1 = new("Joao");
    conta1.Depositar(10);

    ContaCorrente conta2 = new("Pedro");
    conta2.Depositar(10);

    conta2.Transferir(5, conta1);

    Console.WriteLine($"Saldo da conta1 Depois {conta1.Saldo}");
    Console.WriteLine($"Saldo da conta2 Depois {conta2.Saldo}");
}

void RelatorioTotalizadorDeContas()
{
    ContaCorrente conta1 = new("Pedro");
    conta1.Depositar(10);

    ContaPoupanca conta2 = new("João");
    conta2.Depositar(100);

    ContaCorrente conta3 = new("Maria");
    conta3.Depositar(100);

    TotalizadorDeConta relatorio = new();
    relatorio.Somar(conta1);
    relatorio.Somar(conta2);
    relatorio.Somar(conta3);

    Console.WriteLine($"Valor Total: {relatorio.ValorTotal}");
}

void RelatorioTotalizadorDeTributos()
{
    ContaInvestimento conta1 = new("Pedro");
    conta1.Depositar(1000);

    SeguroDeVida conta2 = new();
    conta2.Saldo = 100;

    TotalizadorDeTributos relatorio = new();
    relatorio.Acumular(conta1);
    relatorio.Acumular(conta2);


    Console.WriteLine($"Valor Total: {relatorio.Total}");
}