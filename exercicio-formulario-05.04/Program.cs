//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viúvo(a)), 'd'(divorciado(a));


bool nomeCerto = true;

do
{
    Console.WriteLine($"Insira um nome *Campo obrigatório");
    string nome = Console.ReadLine();
    
    if (nome == "")
    {
        nomeCerto = true;
    }

    else
    nomeCerto = false;


} while (nomeCerto);

bool idadeCerta = true;

do
{
    Console.WriteLine($"Insira uma idade *Entre 0 e 100 anos");
    int idade = int.Parse(Console.ReadLine());

    if (idade > 0 && idade <100)
    {
        idadeCerta = false;
    }

    else
    idadeCerta = true;

} while (idadeCerta);


bool salarioCerto = true;

do
{
    Console.WriteLine($"Insira seu salário *Deve ser maior que 0");
    float salario = float.Parse(Console.ReadLine());

    if (salario > 0)
    {
        salarioCerto = false;
    }

    else
    salarioCerto = true;

} while (salarioCerto);


bool estadoCivil = true;
do
{
    Console.WriteLine($"Insira seu estado civil *'s' para solteiro, 'c' para casado, 'v' para viúvo e 'd' para divorciado");
    char estado = char.Parse(Console.ReadLine());

    if (estado != 's' && estado != 'c' && estado != 'v' && estado != 'd')
    {
        estadoCivil = true;
    }
    
    else
    estadoCivil = false;

} while (estadoCivil);

Console.WriteLine($"Cadastro realizado com sucesso");
