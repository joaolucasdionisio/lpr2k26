using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de nomes: ");
        int qtd = int.Parse(Console.ReadLine());

        var nomes = new List<string>();
        for (int i = 1; i <= qtd; i++)
        {   
            Console.Write($"Digite o nome {i}: ");
            nomes.Add(Console.ReadLine());
        }

        var linhas = new List<string>();
        foreach (var nome in nomes)
        {
            int tmamaho =  nome.Length;
            bool colocado = false;
            foreach (var linha in linhas)
            {
                bool temTamanho = linha.Any(n => n.Length == tmamaho);
                if (!temTamanho)
                {
                    linha.Add(nome);
                    colocado = true;
                    break;
                }
            }
            if (!colocado)
            {
                linhas.Add(new List<string> { nome });
            }
        }
        Console.WriteLine();
        foreach (var linha in linhas)
        {
            var ordenada = linha.OrderBy(n => n.Length);
            Console.WriteLine(string.Join(", ", ordenada));
        }
    }
}