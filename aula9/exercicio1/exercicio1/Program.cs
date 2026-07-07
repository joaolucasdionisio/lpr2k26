using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var notas = new List<int>();

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite a nota {i}: ");
            Console.WriteLine();
            Console.Write("Digite um número inteiro entre 0 e 10.");
            if (int.TryParse(Console.ReadLine(), out int nota))
            {
                notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número válido.");
                i--;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Notas cadastradas:");
        foreach (var nota in notas)
        {
            Console.WriteLine(nota);
        }

        int maior = int.MinValue;
        int menor = int.MaxValue;
        int soma = 0;

        foreach (var nota in notas)
        {
            if (nota > maior) maior = nota;
            if (nota < menor) menor = nota;
            soma += nota;
        }

        double media = soma / (double)notas.Count;

        Console.WriteLine();
        Console.WriteLine($"Maior nota: {maior}");
        Console.WriteLine($"Menor nota: {menor}");
        Console.WriteLine($"Média das notas: {media:F2}");
    }
}
