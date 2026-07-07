using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
       Dictionary<string, int> cidades = new Dictionary<string, int>();

       Console.Write("Quantas cidades você quer cadastrar? ");
       int x = int.Parse(Console.ReadLine());

       for (int i = 0; i < x; i++)
        {
            Console.Write($"Nome da cidade {i + 1}: ");
            string nome = Console.ReadLine();

            Console.Write($"População de {nome}: ");
            int populacao = int.Parse(Console.ReadLine());

            cidades[nome] = populacao;
        }
         Console.WriteLine("\n Dicionário completo ");
        foreach (var par in cidades)
        {
            Console.WriteLine($"{par.Key}: {par.Value}");
        }
        double media = cidades.Values.Average();
        Console.WriteLine($"\nMédia de população: {media:F2}");

        Console.WriteLine("Cidades com população acima da média:");
        foreach (var par in cidades.Where(c => c.Value > media))
        {
            Console.WriteLine($"{par.Key}: {par.Value}");
        }
        var maisPopulosa = cidades.OrderByDescending(c => c.Value).First();
        var menosPopulosa = cidades.OrderBy(c => c.Value).First();
        Console.WriteLine($"\nCidade mais populosa: {maisPopulosa.Key} ({maisPopulosa.Value})");
        Console.WriteLine($"Cidade menos populosa: {menosPopulosa.Key} ({menosPopulosa.Value})");
        Console.Write("\nDigite o valor Y (população a ser removida): ");
        int y = int.Parse(Console.ReadLine());
        var chavesParaRemover = cidades.Where(c => c.Value == y)
                                        .Select(c => c.Key)
                                        .ToList();

        foreach (var chave in chavesParaRemover)
        {
            cidades.Remove(chave);
        }
        Console.WriteLine("\nDicionário atualizado após remoção:");
        foreach (var par in cidades)
        {
            Console.WriteLine($"{par.Key}: {par.Value}");
        }                                
    }
}