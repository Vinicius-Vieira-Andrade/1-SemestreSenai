// 2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações

bool validar = true;

do
{
    Console.WriteLine($"Informe seu usuário: ");
    string usuario = Console.ReadLine();

    Console.WriteLine($"Informe sua senha: ");
    string senha = Console.ReadLine();

    if (usuario == senha)
    {
        validar = true;
        Console.WriteLine($"Dados inválidos, não será aceito usuario e senha repetidos!");
        
    }

    else
    {
    validar = false;
    Console.WriteLine($"Cadastro realizado com sucesso");
    }

} while (validar);

