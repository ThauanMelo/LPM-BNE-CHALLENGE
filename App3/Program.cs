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

        // Lê número de meses
        Console.Write("Digite o número de meses: ");
        int numMeses = int.Parse(Console.ReadLine());

        // Exibe valor inicial
        Console.WriteLine($"Valor inicial: {valorInicial:F2}");

        // Calcula e exibe rendimento em cada mês
        Console.WriteLine("Rendimento em cada mês:");
        for (int i = 1; i <= numMeses; i++)
        {
            double rendimento = valorInicial * Math.Pow(1 + taxaJuros, i) - valorInicial;
            Console.WriteLine($"Mês {i}: {rendimento:F2}");
        }

        // Calcula e exibe rendimento total
        double rendimentoTotal = valorInicial * Math.Pow(1 + taxaJuros, numMeses) - valorInicial;
        Console.WriteLine($"Rendimento total após {numMeses} meses: {rendimentoTotal:F2}");

        // Aguarda usuário pressionar uma tecla para encerrar o programa
        Console.ReadKey();
    }
}
