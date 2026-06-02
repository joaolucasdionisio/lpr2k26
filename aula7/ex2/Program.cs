int[] vetor =  new int[10];
int contador = 0;

for (int i = 0; i < vetor.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número inteiro: ");
    vetor[i] = int.TryParse(Console.ReadLine(), out int valor) ? valor : 0;
}
Console.Write("Digite um número para verificar se ele está presente no vetor: ");
int numero = int.TryParse(Console.ReadLine(), out int numero_temp) ? numero_temp : 0;

for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] == numero)
    {
        Console.WriteLine($"O número {numero} está presente no vetor, e está na posição {i}.");
        contador++;
    }
}

Console.WriteLine($"O número {numero} aparece {contador} vezes no vetor.");