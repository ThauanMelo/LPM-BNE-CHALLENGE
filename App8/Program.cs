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
        double rendimentoRestante = CalcularRendimento(valorAposResgate, taxaJuros, numDias);

        // Mostra tabela de rendimento
        Console.WriteLine("Tabela de rendimento:");
        Console.WriteLine("Mês\t\tRendimento");
        Console.WriteLine("---------------------------");
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"{i}\t\t{CalcularRendimento(valorInicial, taxaJuros, i * 30)}");
        }
        Console.WriteLine($"5 (resgate)\t{rendimento4Meses:F2}");
        Console.WriteLine("---------------------------");
        for (int i = 6; i <= 8; i++)
        {
            Console.WriteLine($"{i}\t\t{CalcularRendimento(valorAposResgate, taxaJuros, (i - 5) * 30)}");
        }
        Console.WriteLine("9\t\t{0:F2}", CalcularRendimento(valorAposResgate, taxaJuros, 240));
        Console.WriteLine("10\t\t{0:F2}", rendimentoRestante);

        // Mostra rendimento futuro
        Console.WriteLine($"Rendimento futuro após resgate no 5º mês: {valorAposResgate + rendimentoRestante:F2}");

        // Aguarda usuário pressionar uma tecla para encerrar o programa
        Console.ReadKey();
    }

    static double CalcularRendimento(double valorInicial, double taxaJuros, int numDias)
    {
        double rendimento = valorInicial * Math.Pow(1 + taxaJuros, numDias / 30.0) - valorInicial;
        return rendimento;
    }
}