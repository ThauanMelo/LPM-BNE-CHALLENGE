using System;

class Program
{
    static void Main(string[] args)
    {

        // Lê valor inicial
        Console.Write("Digite o valor inicial: ");
        double valorInicial = double.Parse(Console.ReadLine());

        // Lê taxa de juros
        Console.Write("Digite a taxa de juros (em % ao mês): ");
        double taxaJuros = double.Parse(Console.ReadLine()) / 100;

        // Calcula rendimento para 4 meses
        double rendimento4Meses = CalcularRendimento(valorInicial, taxaJuros, 4 * 30);

        // Calcula valor após resgate no 5º mês
        double valorAposResgate = valorInicial + rendimento4Meses;

        // Calcula rendimento para os próximos 4 meses e 10 dias
        int numDias = 4 * 30 + 10;
        double rendimentoRestante = CalcularRendimento(valorAposResgate - 1000, taxaJuros, numDias);

        // Mostra tabela de rendimento
        Console.WriteLine("Valor Investido\tTaxa de Juros\tRendimento\tPeríodo (a.m.)\tResgate\t\tSaldo Líquido");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"{valorInicial:C2}\t\t{taxaJuros:P2}\t\t{CalcularRendimento(valorInicial, taxaJuros, i * 30):C2}\t\t{i}\t\t-\t\t{valorInicial + CalcularRendimento(valorInicial, taxaJuros, i * 30):C2}");
        }
        Console.WriteLine($"{valorInicial:C2}\t\t{taxaJuros:P2}\t\t{rendimento4Meses:C2}\t\t5\t\t1000\t\t{valorAposResgate:C2}");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        for (int i = 6; i <= 8; i++)
        {
            Console.WriteLine($"{valorAposResgate:C2}\t\t{taxaJuros:P2}\t\t{CalcularRendimento(valorAposResgate, taxaJuros, (i - 5) * 30):C2}\t\t{i}\t\t-\t\t{valorAposResgate + CalcularRendimento(valorAposResgate, taxaJuros, (i - 5) * 30):C2}");
        }
        Console.WriteLine($"{valorAposResgate:C2}\t\t{taxaJuros:P2}\t\t{rendimentoRestante:C2}\t\t9\t\t-\t\t{valorAposResgate + rendimentoRestante:C2}");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        // Mostra rendimento futuro
        Console.WriteLine($"Rendimento futuro após resgate no 5º mês: {valorAposResgate + rendimentoRestante:C2}");

        // Aguarda usuário pressionar uma tecla para encerrar o programa
        Console.ReadKey();
    }

    static double CalcularRendimento(double valorInicial, double taxaJuros, int numDias)
    {
        double rendimento = valorInicial * Math.Pow(1 + taxaJuros, numDias / 30.0) - valorInicial;
        return rendimento;
    }
}