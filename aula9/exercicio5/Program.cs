using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        Console.Write("Quantas pessoas deseja cadastrar (Valor X)? ");
        int x = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < x; i++)
        {
            Console.Write($"Digite o nome da {i + 1}ª pessoa: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write($"Digite a idade de {nome}: ");
            int idade = int.Parse(Console.ReadLine() ?? "0");

            pessoas[nome] = idade;
        }

        if (pessoas.Count > 0)
        {
            double mediaIdades = pessoas.Values.Average();
            Console.WriteLine($"\nMédia das idades: {mediaIdades:F2}");
            Console.WriteLine("Pessoas com idade acima da média:");
            
            foreach (KeyValuePair<string, int> par in pessoas)
            {
                if (par.Value > mediaIdades)
                {
                    Console.WriteLine($"- {par.Key} ({par.Value} anos)");
                }
            }
        }

        string maisVelha = "";
        string maisNova = "";
        int maiorIdade = int.MinValue;
        int menorIdade = int.MaxValue;

        foreach (KeyValuePair<string, int> par in pessoas)
        {
            if (par.Value > maiorIdade)
            {
                maiorIdade = par.Value;
                maisVelha = par.Key;
            }
            if (par.Value < menorIdade)
            {
                menorIdade = par.Value;
                maisNova = par.Key;
            }
        }

        if (pessoas.Count > 0)
        {
            Console.WriteLine($"\nPessoa mais velha: {maisVelha} ({maiorIdade} anos)");
            Console.WriteLine($"Pessoa mais nova: {maisNova} ({menorIdade} anos)");
        }

        Console.Write("\nDigite uma idade para remover do dicionário (Valor Y): ");
        int y = int.Parse(Console.ReadLine() ?? "0");

        List<string> chavesParaRemover = new List<string>();
        foreach (KeyValuePair<string, int> par in pessoas)
        {
            if (par.Value == y)
            {
                chavesParaRemover.Add(par.Key);
            }
        }

        foreach (string nome in chavesParaRemover)
        {
            pessoas.Remove(nome);
        }

        Console.WriteLine("\nDicionário Atualizado:");
        foreach (KeyValuePair<string, int> par in pessoas)
        {
            Console.WriteLine($"{par.Key}: {par.Value} anos");
        }
    }
}