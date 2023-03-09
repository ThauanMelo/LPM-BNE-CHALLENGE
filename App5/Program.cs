using System;

class Program
{
    static void Main(string[] args)
    {
        // Valor inicial do investimento
        double valorInicial = 3800.00;

        // Taxa de juros mensal
        double taxaJurosMensal = 1.25 / 100;

        // Número de meses
        int meses = 6;

        // Valor futuro desejado
        double valorFuturoDesejado = 7390.61;

        // Cálculo do valor necessário para atingir o valor futuro desejado
        double valorNecessario = (valorFuturoDesejado / Math.Pow(1 + taxaJurosMensal, meses));

        // Exibição do resultado
        Console.WriteLine("Valor inicial do investimento: R$ {0:F2}", valorInicial);
        Console.WriteLine("Taxa de juros mensal: {0:F2}%", taxaJurosMensal * 100);
        Console.WriteLine("Período de tempo em meses: {0}", meses);
        Console.WriteLine("Valor futuro desejado: R$ {0:F2}", valorFuturoDesejado);
        Console.WriteLine("Valor necessário para atingir o valor futuro desejado: R$ {0:F2}", valorNecessario);
    }
}
