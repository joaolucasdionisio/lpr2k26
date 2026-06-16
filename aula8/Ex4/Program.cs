using System;

struct Heroi
{
    public string Nome;
    public int Poder;
    public int Pontuacao;
}

struct Equipe
{
    public Heroi[] Herois;
}

class Program
{
    static void Main()
    {
        Heroi[] herois = new Heroi[5];
        int qtdHerois = 0;

        Equipe equipe = new Equipe();
        equipe.Herois = new Heroi[3];

        MenuPrincipal(herois, ref qtdHerois, ref equipe);
    }

    static void MenuPrincipal(Heroi[] herois, ref int qtdHerois, ref Equipe equipe)
    {
        int opcao;

        do
        {
            Console.WriteLine("\nSELEÇÃO DE HERÓIS MARVEL");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            string? linha = Console.ReadLine();
            if (!int.TryParse(linha, out opcao))
            {
                opcao = 0;
            }

            switch (opcao)
            {
                case 1:
                    CadastrarHeroi(herois, ref qtdHerois);
                    break;

                case 2:
                    SelecionarEquipe(herois, qtdHerois, ref equipe);
                    break;

                case 3:
                    ExibirEquipe(equipe);
                    break;

                case 4:
                    Console.WriteLine("Encerrando programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 4);
    }

    static void CadastrarHeroi(Heroi[] herois, ref int qtdHerois)
    {
        if (qtdHerois >= 5)
        {
            Console.WriteLine("Limite de 5 heróis atingido!");
            return;
        }

        Console.Write("Nome do herói: ");
        herois[qtdHerois].Nome = Console.ReadLine() ?? "";

        Console.Write("Poder do herói: ");
        herois[qtdHerois].Poder = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Pontuação do herói: ");
        herois[qtdHerois].Pontuacao = int.Parse(Console.ReadLine() ?? "0");

        qtdHerois++;

        Console.WriteLine("Herói cadastrado com sucesso!");
    }

    static void SelecionarEquipe(Heroi[] herois, int qtdHerois, ref Equipe equipe)
    {
        if (qtdHerois < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 heróis antes de montar a equipe.");
            return;
        }

        Console.WriteLine("\n=== HERÓIS DISPONÍVEIS ===");

        for (int i = 0; i < qtdHerois; i++)
        {
            Console.WriteLine($"{i} - {herois[i].Nome} | Poder: {herois[i].Poder} | Pontuação: {herois[i].Pontuacao}");
        }

        for (int i = 0; i < 3; i++)
        {
            int indice;
            while (true)
            {
                Console.Write($"\nEscolha o herói {i + 1}: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out indice) && indice >= 0 && indice < qtdHerois)
                {
                    equipe.Herois[i] = herois[indice];
                    break;
                }

                Console.WriteLine("Índice inválido! Tente novamente.");
            }
        }

        Console.WriteLine("Equipe montada com sucesso!");
    }

    static int CalcularPontuacaoTotal(Equipe equipe)
    {
        int total = 0;

        for (int i = 0; i < equipe.Herois.Length; i++)
        {
            total += equipe.Herois[i].Pontuacao;
        }

        return total;
    }

    static void ExibirEquipe(Equipe equipe)
    {
        Console.WriteLine("\nEQUIPE SELECIONADA");

        for (int i = 0; i < equipe.Herois.Length; i++)
        {
            if (!string.IsNullOrEmpty(equipe.Herois[i].Nome))
            {
                Console.WriteLine(
                    $"Herói: {equipe.Herois[i].Nome} | " +
                    $"Poder: {equipe.Herois[i].Poder} | " +
                    $"Pontuação: {equipe.Herois[i].Pontuacao}");
            }
        }

        Console.WriteLine($"\nPontuação Total da Equipe: {CalcularPontuacaoTotal(equipe)}");
    }
}