// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à "40028922".
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

string[] nomes = new string[5];
string[] origens = new string[5];
string[] destinos = new string[5];
string[] datas = new string[5];

//funcao cadastrar passagem
static void CadastrarPassagem(string[] nomes, string[] origens, string[] destinos, string[] datas)
{
    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine($"Insira o nome: ");
        nomes[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira a origem: ");
        origens[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira o destino: ");
        destinos[i] = Console.ReadLine()!;

        Console.WriteLine($"Insira a data: ");
        datas[i] = Console.ReadLine()!;
    }
}

//Funcao listar passagem
static void ListarPassagem(string[] nomes, string[] origens, string[] destinos, string[] datas)
{
    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine(@$"
        *********************
        Passagens - Bilhete

        Nome: {nomes[i]}

        Origem: {origens[i]}

        Destino: {destinos[i]}

        Data: {datas[i]}
        ");
    }
}

//FUNCAO SENHA LOGIN
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

//RODAR PROGRAMA
Console.WriteLine($"Bem vindo a tela de login !!");

Console.WriteLine($"Insira seu usuário: ");
string usuarioLogin = Console.ReadLine()!;

SenhaLogin();

Console.WriteLine($"Login realizado com sucesso!!");


//MENU OPCOES
Mennu:  //CHECKPOINT
bool validarMenu = true;
do
{
    Console.WriteLine(@$"

----------------------------
| Bem vindo ao menu opções |
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

    if (menuResposta == 1)
    {

        CadastrarPassagem(nomes, origens, destinos, datas);
        Console.WriteLine(@$"
        Cadastro realizado com sucesso, deseja cadastrar uma nova passagem?

        Utilize 's' para sim e 'n'
        ");

        char repostaCadastro = char.Parse(Console.ReadLine()!);

        if (repostaCadastro == 's')
        {
            CadastrarPassagem(nomes, origens, destinos, datas);
        }

        else if (repostaCadastro == 'n')
        {
            goto Mennu; //CHAMAR CHECKPOINT
        }
    }

    else if (menuResposta == 2)
    {
        ListarPassagem(nomes, origens, destinos, datas);
    }

    else if (menuResposta == 0)
    {
        Console.WriteLine($"Fim do programa");
        break;
    }

    else
    {
        Console.WriteLine($"Opção inválida");
        
    }

} while (validarMenu == true);



