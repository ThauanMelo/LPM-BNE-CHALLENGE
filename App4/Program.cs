using System;

class Program
{
    static void Main(string[] args)
    {
        double valorInicial = 2000;
        double taxaJuros = 0.02;
        double taxaJurosAnual = 0.005;
        double saldo = valorInicial;

        Console.WriteLine("| Mês | Saldo Inicial | Juros (2% am) | Rendimento | Saque | Saldo Final |");
        Console.WriteLine("|-----|---------------|---------------|------------|-------|-------------|");

        for (int mes = 1; mes <= 6; mes++)
        {
            double juros = saldo * taxaJuros;
            double rendimento = (saldo + juros) * taxaJurosAnual / 12;
            double saque = 0;

            if (mes == 5)
            {
                saque = 1000;
            }

            saldo += juros + rendimento - saque;

            Console.WriteLine($"| {mes,-3} | {saldo,-13:C2} | {juros,-13:C2} | {rendimento,-10:C2} | {saque,-5:C2} | {saldo,-11:C2} |");
        }
    }
}
