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

        // Calcula rendimento para 8 meses e 10 dias
        int numDias = 8 * 30 + 10;
        double rendimento = CalcularRendimento(valorInicial, taxaJuros, numDias);

        // Mostra tabela de rendimento para 8 meses e 10 dias
        Console.WriteLine("Tabela de rendimento para 8 meses e 10 dias:");
        Console.WriteLine("Mês\t\tRendimento");
        Console.WriteLine("---------------------------");
        for (int i = 1; i <= 8; i++)
        {
            Console.WriteLine($"{i}\t\t{CalcularRendimento(valorInicial, taxaJuros, i * 30)}");
        }
        Console.WriteLine("9\t\t{0:F2}", CalcularRendimento(valorInicial, taxaJuros, 270));
        Console.WriteLine("10\t\t{0:F2}", CalcularRendimento(valorInicial, taxaJuros, numDias));

        // Mostra rendimento futuro
        Console.WriteLine($"Rendimento futuro após 8 meses e 10 dias: {valorInicial + rendimento:F2}");

        // Aguarda usuário pressionar uma tecla para encerrar o programa
        Console.ReadKey();
    }

    static double CalcularRendimento(double valorInicial, double taxaJuros, int numDias)
    {
        double rendimento = valorInicial * Math.Pow(1 + taxaJuros, numDias / 30.0) - valorInicial;
        return rendimento;
    }
}
