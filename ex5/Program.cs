using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[4, 4]
        {
         {0, 524, 521, 822},
         {524, 0, 434, 586},
         {521, 434, 0, 429},
         {822, 586, 429, 0}
        };

        Console.WriteLine("Entre com duas cidades:");
        switch (Console.ReadLine())
        {
            case "Vitória e Vitória":
            Console.WriteLine("Distância entre Vitória e Vitória: " + matriz[0, 0]);
            break;
            case "Vitória e Belo Horizonte":
            Console.WriteLine("Distância entre Vitória e Belo Horizonte: " + matriz[0, 1]);
            break;
            case "Vitória e Rio de Janeiro":
            Console.WriteLine("Distância entre Vitória e Rio de Janeiro: " + matriz[0, 2]);
            break;
            case "Vitória e São Paulo":
            Console.WriteLine("Distância entre Vitória e São Paulo: " + matriz[0, 3]);
            break;
            case "Belo Horizonte e Vitória":
            Console.WriteLine("Distância entre Belo Horizonte e Vitória: " + matriz[1, 0]);
            break;
            case "Belo Horizonte e Rio de Janeiro":
            Console.WriteLine("Distância entre Belo Horizonte e Rio de Janeiro: " + matriz[1, 2]);
            break;
            case "Belo Horizonte e São Paulo":
            Console.WriteLine("Distância entre Belo Horizonte e São Paulo: " + matriz[1, 3]);
            break;
            case "Rio de Janeiro e Vitória":
            Console.WriteLine("Distância entre Rio de Janeiro e Vitória: " + matriz[2, 0]);
            break;
            case "Rio de Janeiro e Belo Horizonte":
            Console.WriteLine("Distância entre Rio de Janeiro e Belo Horizonte: " + matriz[2, 1]);
            break;
            case "Rio de Janeiro e São Paulo":
            Console.WriteLine("Distância entre Rio de Janeiro e São Paulo: " + matriz[2, 3]);
            break;
            case "São Paulo e Vitória":
            Console.WriteLine("Distância entre São Paulo e Vitória: " + matriz[3, 0]);
            break;
            case "São Paulo e Belo Horizonte":
            Console.WriteLine("Distância entre São Paulo e Belo Horizonte: " + matriz[3, 1]);
            break;
            case "São Paulo e Rio de Janeiro":
            Console.WriteLine("Distância entre São Paulo e Rio de Janeiro: " + matriz[3, 2]);
            break;
        }
}
}