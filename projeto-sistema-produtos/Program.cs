// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

string[] nomes = new string[2];
float[] precos = new float[2];
bool[] promocoes = new bool[2];

bool validarMenu = true;

bool validarUsuario = true;
bool validarSenha = true;

static void Cadastramento(string[] nomes, float[] precos, bool[] promocoes)
{
    for (var i = 0; i < 2; i++)
    {
        Console.WriteLine($"Insira o nome do produto");
        nomes[i] = Console.ReadLine()!;
        Console.WriteLine($"Insira o preço do produto");
        precos[i] = float.Parse(Console.ReadLine()!);

    check:
        Console.WriteLine($"O produto está em promocão? *para SIM digite (s) e para NÃO digite (n)");
        string respostaPromo = Console.ReadLine()!;

        if (respostaPromo == "s")
        {
            promocoes[i] = true;
        }
        else if (respostaPromo == "n")
        {
            promocoes[i] = false;
        }
        else
        {
            Console.WriteLine($"Opção inválida, tente novamente");
            goto check;
        }
    }
}

static void listarProdutos(string[] nomes, float[] precos, bool[] promocoes)
{
    for (var i = 0; i < 2; i++)
    {
        Console.WriteLine(@$"
            -------------------------
                Dados do produtos

            Nome: {nomes[i]}

            Preço: {precos[i]}

            promocão: {promocoes[i]}
            -------------------------
        ");
    }
}


//RODAR PROGRAMA
Console.WriteLine(@$"
    Bem vindo a tela de login
");

do
{
    Console.WriteLine($"Digite seu usuário: ");
    string usuario = Console.ReadLine()!;
    if (usuario != "ze da manga")
    {
        validarUsuario = true;
        Console.WriteLine($"Usuario inválido!");
    }
    else
    {
        validarUsuario = false;
        Console.WriteLine($"Usuario correto, prossiga!");
        break;
    }
} while (validarUsuario == true);

do
{
    Console.WriteLine($"Digite sua senha: ");
    string senha = Console.ReadLine()!;
    if (senha != "ornitorrinco")
    {
        validarSenha = true;
        Console.WriteLine($"Senha inválida!");
    }
    else
    {
        validarSenha = false;
        Console.WriteLine($"Login realizado com sucesso");
        break;
    }
} while (validarSenha == true);

//MENU OPCOES

do
{
repetirMenu:
    Console.WriteLine(@$"
 ______________________________________
|                                      |
|   Bem vindo ao menu de opções!       |
|                                      |
|     Escolha uma das opções:          |
|                                      |
|                                      |
|    (1)Cadastrar Produto              |
|    (2)Listar Produtos                |
|    (0)Sair                           |
|                                      |
|______________________________________|    
");
    string respostaMenu = Console.ReadLine()!;

    if (respostaMenu == "1")
    {
        Cadastramento(nomes, precos, promocoes);

        Console.WriteLine(@$"
        Cadastro do produto realizado com sucesso!

        Deseja cadastrar outro produto?

        's' para SIM e 'n' para NÃO
        ");

        string respostaCadastro = Console.ReadLine()!;
        if (respostaCadastro == "s")
        {
            Cadastramento(nomes, precos, promocoes);
        }
    }

    else if (respostaMenu == "2")
    {
        listarProdutos(nomes, precos, promocoes);
    }

    else if (respostaMenu == "0")
    {
        Console.WriteLine($"Opção inválida, tente novamente");
        goto repetirMenu;
    }

} while (validarMenu == true);











