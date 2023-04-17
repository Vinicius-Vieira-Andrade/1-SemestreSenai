// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à "40028922".
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

//declarar as variaveis
string[] nomes = new string[5];
string[] origens = new string[5];
string[] destinos = new string[5];
string[] datas = new string[5];

//funcao cadastrar passagem
static void CadastrarPassagem()
{
     string[] nomes = new string[5];
     string[] origens = new string[5];
     string[] destinos = new string[5];
     string[] datas = new string[5];

    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine($"Insira o nome do passageiro: ");
        nomes[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira a origem do passageiro: ");
        origens[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira o destino do passageiro: ");
        destinos[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira a data do passageiro: ");
        datas[i] = Console.ReadLine()!;

        Console.WriteLine(@$"
        Cadastro realizado com sucesso, deseja cadastrar uma nova passagem?
        ");
        
    }
}

//Funcao listar passagem
static string ListarPassagem()
{
    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine(@$"
        
        ");
    }
}



//Programa
Console.WriteLine($"Bem vindo a tela de login !!");

Console.WriteLine($"Insira seu usuário: ");
string usuarioLogin = Console.ReadLine()!;

//FUNCAO LOGIN
static void SenhaLogin()
{
    bool validarSenha = true;
    do
    {
        Console.WriteLine($"Insira uma senha válida: ");
        int senhaDeLogin = int.Parse(Console.ReadLine()!);
        if (senhaDeLogin != 40028922)
        {
            validarSenha = true;
            Console.WriteLine($"Senha invalida");
        }

        else
        {
            validarSenha = false;
            Console.WriteLine($"Senha válida, prossiga!");
        }

    } while (validarSenha == true);
}

SenhaLogin();

Console.WriteLine($"Login realizado com sucesso!!");

//menu
bool validarMenu = true;

do
{
    Console.WriteLine(@$"

----------------------------
| Bem vindo ao nosso menu! |
|                          |
|  Escolha uma das opções: |   
|                          |
|   1. Cadastrar passagem  | 
|   2. Listrar passagens   |
|   0. Sair                |
|                          |
----------------------------

");
    int menuResposta = int.Parse(Console.ReadLine()!);

    switch (menuResposta)
    {
        case 0:
            break;
        case 1:
            CadastrarPassagem();
            break;

        default:
            break;
    }


} while (validarMenu == true);



