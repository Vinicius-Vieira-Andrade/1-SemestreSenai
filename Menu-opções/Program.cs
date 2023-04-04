//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional

Console.WriteLine(@$"

|-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-|
|                                           |
|            Programa de bebidas            |
|                                           |
|              Seja bem-vindo               |
|         temos as seguintes bebidas:       |
|                                           |
|            1. Coca-Cola                   |
|            2. Pepsi                       |
|            3. Chá                         |
|            4. Dollão                      |
|                                           |
|-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-|

");

Console.WriteLine($"O que irá escolher? ");
int bebidas = int.Parse(Console.ReadLine());

switch (bebidas)
{
    case 1:
        Console.WriteLine(@$"
    
    Gostaria de adicionar gelo?
    1. Sim
    2. Não
    ");

        int escolha1 = int.Parse(Console.ReadLine());

        if (escolha1 == 1)
        {
            Console.WriteLine($"Sua bebida terá gelo");
        }

        else if (escolha1 == 2)
        {
            Console.WriteLine($"Sua bebida não terá gelo");
        }

        else
        {
            Console.WriteLine($"Digite apenas 1 para sim e 2 para não");
        }
        break;

    case 2:
        Console.WriteLine(@$"
    
    Gostaria de adicionar gelo?
    1. Sim
    2. Não
    ");

        int escolha2 = int.Parse(Console.ReadLine());

        if (escolha2 == 1)
        {
            Console.WriteLine($"Sua bebida terá gelo");
        }

        else if (escolha2 == 2)
        {
            Console.WriteLine($"Sua bebida não terá gelo");
        }

        else
        {
            Console.WriteLine($"Digite apenas 1 para sim e 2 para não");
        }
        break;

    case 3:
        Console.WriteLine(@$"
    
    Gostaria de adicionar gelo?
    1. Sim
    2. Não
    ");

        int escolha3 = int.Parse(Console.ReadLine());

        if (escolha3 == 1)
        {
            Console.WriteLine($"Sua bebida terá gelo");
        }

        else if (escolha3 == 2)
        {
            Console.WriteLine($"Sua bebida não terá gelo");
        }

        else
        {
            Console.WriteLine($"Digite apenas 1 para sim e 2 para não");
        }
        break;

    case 4:
        Console.WriteLine(@$"
    
    Gostaria de adicionar gelo?
    1. Sim
    2. Não
    ");

        int escolha4 = int.Parse(Console.ReadLine());

        if (escolha4 == 1)
        {
            Console.WriteLine($"Sua bebida terá gelo");
        }

        else if (escolha4 == 2)
        {
            Console.WriteLine($"Sua bebida não terá gelo");
        }

        else
        {
            Console.WriteLine($"Digite apenas 1 para sim e 2 para não");
        }
        break;

}