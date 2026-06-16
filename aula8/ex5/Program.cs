using System;

struct Chamado
{
    public int Numero;
    public string Solicitante;
    public string Setor;
    public int Prioridade;
    public string Status;
    public string Descricao;
}

class Program
{
    static Chamado[] chamados = new Chamado[10];
    static int quantidade = 0;

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n MENU ");
            Console.WriteLine("1 - Cadastrar chamado");
            Console.WriteLine("2 - Listar chamados");
            Console.WriteLine("3 - Atualizar status");
            Console.WriteLine("4 - Estatísticas");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastrarChamado();
                    break;

                case 2:
                    listarChamados();
                    break;

                case 3:
                    atualizarStatus();
                    break;

                case 4:
                    estatisticas();
                    break;

                case 0:
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 0);
    }

    static void cadastrarChamado()
    {
        if (quantidade >= 10)
        {
            Console.WriteLine("Limite de chamados atingido.");
            return;
        }

        Console.Write("Número do chamado: ");
        chamados[quantidade].Numero = int.Parse(Console.ReadLine());

        Console.Write("Solicitante: ");
        chamados[quantidade].Solicitante = Console.ReadLine();

        Console.Write("Setor: ");
        chamados[quantidade].Setor = Console.ReadLine();

        Console.Write("Prioridade (1-Baixa, 2-Média, 3-Alta): ");
        chamados[quantidade].Prioridade = int.Parse(Console.ReadLine());

        Console.Write("Descrição: ");
        chamados[quantidade].Descricao = Console.ReadLine();

        chamados[quantidade].Status = "Aberto";

        quantidade++;

        Console.WriteLine("Chamado cadastrado com sucesso!");
    }

    static void listarChamados()
    {
        if (quantidade == 0)
        {
            Console.WriteLine("Nenhum chamado cadastrado.");
            return;
        }

        Console.WriteLine("\n CHAMADOS ");

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"\nNúmero: {chamados[i].Numero}");
            Console.WriteLine($"Solicitante: {chamados[i].Solicitante}");
            Console.WriteLine($"Setor: {chamados[i].Setor}");
            Console.WriteLine($"Prioridade: {classificarPrioridade(chamados[i].Prioridade)}");
            Console.WriteLine($"Status: {chamados[i].Status}");
            Console.WriteLine($"Descrição: {chamados[i].Descricao}");
        }
    }

    static void atualizarStatus()
    {
        Console.Write("Digite o número do chamado: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            if (chamados[i].Numero == numero)
            {
                Console.WriteLine("1 - Em andamento");
                Console.WriteLine("2 - Resolvido");
                Console.WriteLine("3 - Cancelado");
                Console.Write("Escolha: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        chamados[i].Status = "Em andamento";
                        break;

                    case 2:
                        chamados[i].Status = "Resolvido";
                        break;

                    case 3:
                        chamados[i].Status = "Cancelado";
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        return;
                }

                Console.WriteLine("Status atualizado com sucesso!");
                return;
            }
        }

        Console.WriteLine("Chamado não encontrado.");
    }

    static string classificarPrioridade(int prioridade)
    {
        switch (prioridade)
        {
            case 1:
                return "Baixa";

            case 2:
                return "Média";

            case 3:
                return "Alta";

            default:
                return "Inválida";
        }
    }

    static void estatisticas()
    {
        int abertos = 0;
        int andamento = 0;
        int resolvidos = 0;
        int cancelados = 0;

        for (int i = 0; i < quantidade; i++)
        {
            switch (chamados[i].Status)
            {
                case "Aberto":
                    abertos++;
                    break;

                case "Em andamento":
                    andamento++;
                    break;

                case "Resolvido":
                    resolvidos++;
                    break;

                case "Cancelado":
                    cancelados++;
                    break;
            }
        }

        Console.WriteLine("\n ESTATÍSTICAS ");
        Console.WriteLine($"Chamados abertos: {abertos}");
        Console.WriteLine($"Chamados em andamento: {andamento}");
        Console.WriteLine($"Chamados resolvidos: {resolvidos}");
        Console.WriteLine($"Chamados cancelados: {cancelados}");
    }
}