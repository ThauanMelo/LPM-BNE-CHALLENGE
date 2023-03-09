using System;

class Program
{
    static void Main(string[] args)
    {
        // Valor inicial do investimento
        double valorInicial = 3800.00;

        // Taxa de juros mensal
        double taxaJurosMensal = 1.25 / 100;

        // Taxa de juros anual
        double taxaJurosAnual = 0.5 / 100;

        // Número de meses
        int meses = 6;

        // Cálculo do valor final do investimento
        double valorFinal = valorInicial * Math.Pow(1 + taxaJurosMensal, meses);

        // Cálculo do rendimento total do investimento
        double rendimentoTotal = valorFinal - valorInicial;

        // Exibição do resultado total
        Console.WriteLine("Valor inicial do investimento: R$ {0:F2}", valorInicial);
        Console.WriteLine("Taxa de juros mensal: {0:F2}%", taxaJurosMensal * 100);
        Console.WriteLine("Taxa de juros anual: {0:F2}%", taxaJurosAnual * 100);
        Console.WriteLine("Período de tempo em meses: {0}", meses);
        Console.WriteLine("Valor final do investimento: R$ {0:F2}", valorFinal);
        Console.WriteLine("Rendimento total do investimento: R$ {0:F2}", rendimentoTotal);

        // Cálculo e exibição do rendimento mensal
        double valorAtual = valorInicial;
        Console.WriteLine("\nDetalhamento do rendimento mensal:");
        for (int i = 1; i <= meses; i++)
        {
            double rendimentoMensal = valorAtual * taxaJurosMensal;
            valorAtual += rendimentoMensal;
            Console.WriteLine("Mês {0}: Rendimento R$ {1:F2} / Valor final R$ {2:F2}", i, rendimentoMensal, valorAtual);
        }
    }
}
