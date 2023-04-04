//estrutura switch case

Console.WriteLine($"Informe o número correspondente ao dia da semana:");
int diaSemana = int.Parse(Console.ReadLine()!);

switch (diaSemana)
{
    case 1:
        Console.WriteLine($"é Domingo");
        break;

    case 2:
        Console.WriteLine($"é Segunda-feira");
        break;

    case 3:
        Console.WriteLine($"é Terça-feira");
        break;

    case 4:
        Console.WriteLine($"é Quarta-feira");
        break;

    case 5:
        Console.WriteLine($"é Quinta-feira");
        break;

    case 6:
        Console.WriteLine($"é Sexta-feira");
        break;

    case 7:
        Console.WriteLine($"é sábado");
        break;

    default:
        Console.WriteLine($"O dia informado não corresponde com um dia da semana");
        break;
}
