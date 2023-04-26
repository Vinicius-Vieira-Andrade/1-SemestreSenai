// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using aulaPOOcelular;

Celular cel1 = new Celular();

Console.WriteLine($"Qual o modelo do seu aparelho?");
cel1.modelo = Console.ReadLine()!;
Console.WriteLine($"Qual a cor do seu aparelho?");
cel1.cor = Console.ReadLine()!;

Console.WriteLine($"O celular está ligado? 's' para SIM e 'n' para NÃO!");
string resposta = Console.ReadLine()!.ToLower();

if (resposta == "s")
{
    cel1.ligadoDesligado = true;
}

else
{
    cel1.ligadoDesligado = false;
    Console.WriteLine($"Pressione ENTER para ligar o aparelho");
    Console.ReadLine();
    cel1.Ligar();
}

bool validarMenu = true;
do
{
    Console.WriteLine(@$"
    ***Menu Celular***

    [1] Ligar o celular
    [2] Desligar o celular

    [3] Fazer ligação
    [4] Enviar mensagem
");

    string opcaoMenu = Console.ReadLine()!;

    switch (opcaoMenu)
    {
        case "1":
            validarMenu = true;
            Console.WriteLine($"Celular já esta ligado");
            break;
        case "2":
            validarMenu = false;
            cel1.Desligar();
            break;
        case "3":
            validarMenu = true;
            cel1.FazerLigacao();
            Console.WriteLine($"Ligacão feita, voltando para o menu");
            break;
        case "4":
            validarMenu = true;
            cel1.EnviarMensagem();
            Console.WriteLine($"Mensagem enviada, voltando para o menu");
            break;
        default:
            validarMenu = true;
            Console.WriteLine($"Opção inválida");
            break;
    }

} while (validarMenu);

